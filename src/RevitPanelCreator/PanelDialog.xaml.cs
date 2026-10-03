using System;
using System.Linq;
using Autodesk.Revit.DB;

namespace RevitPanelCreator
{
    public static class PanelCreator
    {
        private const double MillimetersToFeet = 1.0 / 304.8;

        public static void CreateGrid(Document document, PanelSettings settings)
        {
            if (document == null)
            {
                throw new InvalidOperationException("Document is null.");
            }

            var wallType = new FilteredElementCollector(document)
                .OfClass(typeof(WallType))
                .Cast<WallType>()
                .FirstOrDefault();

            if (wallType == null)
            {
                throw new InvalidOperationException("No wall type was found in the project.");
            }

            var level = new FilteredElementCollector(document)
                .OfClass(typeof(Level))
                .Cast<Level>()
                .OrderBy(l => l.Elevation)
                .FirstOrDefault();

            if (level == null)
            {
                throw new InvalidOperationException("No levels were found in the model.");
            }

            using var transaction = new Transaction(document, "Create panel grid");
            transaction.Start();

            var startX = MmToFeet(settings.StartXmm);
            var startY = MmToFeet(settings.StartYmm);
            var panelWidth = MmToFeet(settings.PanelWidthMm);
            var panelHeight = MmToFeet(settings.PanelHeightMm);
            var gap = MmToFeet(settings.GapMm);

            for (var row = 0; row < settings.Rows; row++)
            {
                for (var column = 0; column < settings.Columns; column++)
                {
                    var x0 = startX + column * (panelWidth + gap);
                    var y0 = startY + row * (panelHeight + gap);

                    var line = Line.CreateBound(
                        new XYZ(x0, y0, 0),
                        new XYZ(x0 + panelWidth, y0, 0));

                    Wall.Create(document, line, wallType.Id, level.Id, panelHeight, 0, false, false);
                }
            }

            transaction.Commit();
        }

        private static double MmToFeet(double valueMm)
        {
            return valueMm * MillimetersToFeet;
        }
    }
}

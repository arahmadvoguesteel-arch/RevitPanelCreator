using System;
using Autodesk.Revit.UI;

namespace RevitPanelCreator
{
    public class RevitPanelCreatorApp : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            try
            {
                var ribbonPanel = application.CreateRibbonPanel("Panel Creator");
                var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

                var buttonData = new PushButtonData(
                    "CreatePanelsButton",
                    "Create Panels",
                    assemblyPath,
                    "RevitPanelCreator.CreatePanelsCommand");

                buttonData.ToolTip = "Create a grid of wall panels from custom dimensions.";
                buttonData.LongDescription = "Create a wall panel grid with width, height, gap, rows, and columns.";

                ribbonPanel.AddItem(buttonData);
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                TaskDialog.Show("Revit Panel Creator", $"Failed to start add-in: {ex.Message}");
                return Result.Failed;
            }
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}

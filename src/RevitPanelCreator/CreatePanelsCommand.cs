using System;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Linq;

namespace RevitPanelCreator
{
    [Transaction(TransactionMode.Manual)]
    public class CreatePanelsCommand : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            try
            {
                if (commandData?.Application?.ActiveUIDocument == null)
                {
                    message = "Open a Revit model before running this command.";
                    return Result.Failed;
                }

                var dialog = new PanelDialog(commandData);
                var result = dialog.ShowDialog();

                if (result == true)
                {
                    return Result.Succeeded;
                }

                message = "The command was cancelled by the user.";
                return Result.Cancelled;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
        }
    }
}

# Revit Panel Creator

A Revit add-in for creating a grid of BIM wall panels from custom dimensions and spacing.

Features:
- Create actual Revit wall elements
- Custom panel width, height, and gap
- Rows × columns layout
- Start position in model coordinates
- Revit 2025-ready project template (compatible with later versions)

This project is built as a real add-in that can be installed in Revit using the standard .addin mechanism.

## Project structure

- `src/RevitPanelCreator/` – main source code
- `README.md` – this file
- `.gitignore` – build output exclusions

## Requirements

- Microsoft Visual Studio 2022
- Revit 2025 installed (or later version with matching API references)
- .NET 8 SDK for Windows

## Build steps

1. Open the solution in Visual Studio.
2. Restore NuGet packages if needed.
3. Build the solution in Release x64.
4. Copy the generated DLL to a folder you control, for example:
   `C:\RevitAddins\RevitPanelCreator\`
5. Update the `.addin` file so the `<Assembly>` path points to your DLL location.
6. Copy the `.addin` file to the Revit add-ins folder:
   `C:\ProgramData\Autodesk\Revit\Addins\2025\`
7. Launch Revit and open the Add-Ins tab.

## Add-in manifest

The manifest file is included in the `src/RevitPanelCreator` folder. Update the assembly path before installing.

Example:

```xml
<AddIn Type="Application">
  <Name>Revit Panel Creator</Name>
  <Assembly>C:\RevitAddins\RevitPanelCreator\RevitPanelCreator.dll</Assembly>
  <AddInId>9A2E601B-31D9-4897-BC18-8E8B2AEF6284</AddInId>
  <FullClassName>RevitPanelCreator.RevitPanelCreatorApp</FullClassName>
  <VendorId>RPG</VendorId>
  <VendorDescription>Revit Panel Creator</VendorDescription>
</AddIn>
```

## How the tool works

The add-in opens a dialog where the user enters:
- panel width (mm)
- panel height (mm)
- gap between panels (mm)
- rows
- columns
- start X (mm)
- start Y (mm)

The tool converts millimeters to Revit internal feet and creates multiple wall elements in a rectangular grid.

## Notes

- This is a beginner-friendly starter project that creates actual Revit wall elements, suitable for custom facade panel layouts.
- You may want to refine the logic later for family-based panels, controlled offsets, or curved layouts.
- The default add-in uses a standard wall type selected from the active project.

## Next step ideas

- Add a wall type selector
- Add start point from the current view origin
- Add panel naming or parameter assignment
- Add a custom UI for facade layout patterns
- Add export/import of panel layouts


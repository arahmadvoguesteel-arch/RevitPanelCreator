# Revit Panel Creator

A professional Revit add-in for Revit 2027 that creates a grid of BIM wall panels from custom dimensions, spacing, and layout.

## Features

✅ Create actual Revit wall elements  
✅ Custom panel dimensions (width, height in millimeters)  
✅ Gap between panels  
✅ Rows × columns layout  
✅ Custom start position in model coordinates  
✅ Simple dialog-based interface  
✅ Ideal for facade panel layouts and modular wall systems  

## What It Does

The add-in opens a dialog where you enter:
- Panel width (mm)
- Panel height (mm)
- Gap between panels (mm)
- Number of rows
- Number of columns
- Starting X position (mm)
- Starting Y position (mm)

It then creates actual Revit wall elements arranged in a rectangular grid.

## Requirements

- Revit 2027
- Visual Studio 2022
- .NET 8 SDK for Windows

## Installation

See [INSTALLATION_GUIDE.md](INSTALLATION_GUIDE.md) for full setup steps.

## Build

See [BUILD_INSTRUCTIONS.md](BUILD_INSTRUCTIONS.md) for build steps.

## Project Structure

```text
RevitPanelCreator/
├── src/RevitPanelCreator/
│   ├── RevitPanelCreatorApp.cs
│   ├── CreatePanelsCommand.cs
│   ├── PanelDialog.xaml
│   ├── PanelDialog.xaml.cs
│   ├── PanelCreator.cs
│   ├── PanelSettings.cs
│   ├── RevitPanelCreator.csproj
│   └── RevitPanelCreator.addin
├── RevitPanelCreator.sln
├── README.md
├── INSTALLATION_GUIDE.md
├── BUILD_INSTRUCTIONS.md
└── .gitignore
```

## Example

Input values:
- Panel width: 1200 mm
- Panel height: 3000 mm
- Gap: 50 mm
- Rows: 3
- Columns: 4
- Start X: 0 mm
- Start Y: 0 mm

The tool creates a 3×4 grid of wall panels with 50 mm gaps between them.

## Notes

This is a real Revit BIM add-in and uses actual Revit wall elements.

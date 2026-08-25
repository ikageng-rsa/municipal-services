# Municipal Services Application

A C# .NET Framework Windows Forms application that lets South African residents report
municipal issues (potholes, water outages, sanitation problems, etc.) to their local
municipality.

This is the first milestone of the project. Only the **Report Issues** feature is
implemented so far; **Local Events and Announcements** and **Service Request Status**
are shown on the main menu but disabled, to be implemented in upcoming milestones.

## Requirements

- Windows with **Visual Studio 2022** (or later) installed.
- The **.NET Framework 4.8** targeting pack (installed as part of the ".NET desktop
  development" workload in Visual Studio).

## How to compile and run

1. Open `MunicipalServices.sln` in Visual Studio.
2. Set the build configuration to `Debug` or `Release` (top toolbar).
3. Press `F5` (or `Ctrl+F5` to run without debugging), or use **Build > Build Solution**
   followed by **Debug > Start Without Debugging**.
4. The compiled executable is written to `MunicipalServices\bin\Debug\MunicipalServices.exe`
   (or `bin\Release\...` for a Release build) and can be run directly from there.

To build from the command line instead, run MSBuild against the solution:

```
"C:\Program Files\Microsoft Visual Studio\<version>\<edition>\MSBuild\Current\Bin\MSBuild.exe" MunicipalServices.sln
```

## How to use the application

1. On startup, the **Main Menu** presents three options. Only **Report Issues** is
   enabled; the other two are placeholders for upcoming milestones.
2. Click **Report Issues** to open the Report an Issue form:
   - **Location** – enter a text description of where the issue is (street, suburb, etc.).
   - **Category** – choose the type of issue from the dropdown (Sanitation, Roads,
     Utilities, Public Safety, Parks & Recreation, Other).
   - **Description** – describe the issue in detail.
   - **Attach Media...** – optionally attach one or more photos or documents using the
     file picker.
   - As you fill in the form, the **progress bar and message** below the attachments
     list update to encourage you to complete your report (a gamification-style
     engagement feature).
   - Click **Submit** to save the report. The app validates that location, category,
     and description are filled in before accepting the report, shows a confirmation
     message (including a running count of issues reported this session), and clears
     the form for the next report.
   - Click **Back to Main Menu** at any time to return to the main menu.
3. Reported issues are kept in memory for the lifetime of the application (they are not
   yet persisted to disk as this will be extended in an upcoming milestone).

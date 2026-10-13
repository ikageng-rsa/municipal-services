# Municipal Services Application

A C# .NET Framework Windows Forms application that lets South African residents report
municipal issues (potholes, water outages, sanitation problems, etc.) to their local
municipality.

The project is being built in milestones. **Report Issues** and **Local Events and
Announcements** are implemented; **Service Request Status** is shown on the main menu but
disabled, to be implemented in an upcoming milestone.

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

1. On startup, the **Main Menu** presents three options. **Report Issues** and
   **Local Events & Announcements** are enabled; **Service Request Status** is a
   placeholder for an upcoming milestone.
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
3. Click **Local Events & Announcements** to browse what's happening in the municipality:
   - The **events list** shows upcoming events in date order. Select one to read its
     details (time, place, category and description) in the **Event details** panel.
   - **Search** by **Category** (the dropdown lists each category once), by date (tick
     **On this date** and pick a day within the range that has events), or both. A day
     with no events simply returns no results. Click **Clear** to return to the full list.
   - The **Announcements** panel lists municipal notices with the most urgent first
     (urgent, then important, then general information; newest first within each level).
     Select one to read the full message.
   - **Recommended for you** learns from the categories you search and the events you
     open, and suggests up to four upcoming events you haven't opened yet, each with the
     reason it was suggested. Until you've searched or opened something it shows a hint.
   - **Previous event** steps back through the events you've opened, most recent first.
   - Click **Back to Main Menu** at any time to return to the main menu.
4. Reported issues and the sample events and announcements are kept in memory for the
   lifetime of the application (nothing is persisted to disk yet, as this will be extended
   in an upcoming milestone).

## Data structures

| Feature | Structure | Why |
| --- | --- | --- |
| Reported issues | `List<Issue>` | Simple ordered collection that grows as reports arrive. |
| Announcements | Custom binary min-heap `PriorityQueue<T>` | Always surfaces the most urgent notice first; enqueue and dequeue are O(log n). |
| Event lookup by id | `Dictionary<int, LocalEvent>` | O(1) average lookup. |
| Events by category | `Dictionary<string, List<LocalEvent>>` (case-insensitive) | Jump straight to a category's events without scanning everything. |
| Events by date | `SortedDictionary<DateTime, List<LocalEvent>>` | Keys stay in date order, so events are listed chronologically with no sorting step, and a single day is an O(log n) lookup. |
| Category and date filters | `HashSet<string>` and `SortedSet<DateTime>` | Each category or date is stored once however many events share it; dates stay ordered for the date picker's range. |
| Recent search and view activity | `Queue<T>` (capped at 20) | Oldest activity ages out so recommendations follow current interests. |
| Event view history | `Stack<T>` | Last-in, first-out matches stepping back through events you've opened. |

### How recommendations are scored

Each upcoming event is scored against what you've shown interest in:

- **Interest in its category** counts searches more heavily than opening an event, and
  gives more weight to recent activity than older activity.
- **Related categories** add a smaller share (for example, Environment relates to Health
  and Sports & Recreation), so suggestions aren't limited to what you've already seen.
- **Soon-ness** adds a small bonus for events that are coming up sooner.

The highest-scoring events are picked using the same priority queue used for
announcements.

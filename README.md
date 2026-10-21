# Practical 9 — Placement Dashboard using Data Controls and a Crystal Reports Alternative

This project follows the same general stack as the uploaded Practical 8 project: ASP.NET Core MVC, ADO.NET, SQL Server, and Microsoft.Data.SqlClient. **The uploaded Practical 8 is .NET 10 ASP.NET Core MVC, not ASP.NET Web Forms**; therefore this practical is built to match it and reuse the connection/repository pattern. If your teacher strictly requires `.aspx` Web Forms, tell me because that is a different project type.

## Alternative to Crystal Reports
This implementation uses an HTML-based printable report. Open the report and choose **Print → Save as PDF** in the browser. It needs no Crystal Reports runtime, no report designer installation, and no extra NuGet package. This is the easiest low-dependency alternative for a college practical, although it is not a drag-and-drop report designer like Crystal Reports.

## Practical 8 dependency
Practical 8 is not required to run Practical 9. We reused the approach and structure: SQL Server connection string in `appsettings.json`, a database connection class, ADO.NET repository, MVC controller and views. The database tables must be placement-specific, so this project creates a separate `PlacementDB`.

## Requirements
- Visual Studio 2022 or newer with ASP.NET and web development workload
- .NET 10 SDK (or change TargetFramework to an installed supported SDK)
- SQL Server LocalDB or SQL Server instance

## Run
1. Open `1_Database/01_CreateDatabase.sql` in SQL Server Object Explorer / SSMS and execute it.
2. Execute `1_Database/02_CreateTablesAndSampleData.sql`.
3. Check `appsettings.json`. Default is `(localdb)\MSSQLLocalDB`. For SQL Express use `Server=.\SQLEXPRESS;Database=PlacementDB;Trusted_Connection=True;TrustServerCertificate=True;`.
4. Open `Practical9_PlacementDashboard.csproj` in Visual Studio.
5. Restore NuGet packages, build, then run (Ctrl+F5).
6. Open the dashboard. Filter by placement status. Click **Open Printable Report / Save as PDF**, then click **Print / Save as PDF** and choose **Save as PDF** in the print dialog.

## What it demonstrates
- ADO.NET database connection using `Microsoft.Data.SqlClient`
- SQL joins across Student, Company and Placement tables
- Dashboard cards: total students, placed students, company count and average package
- Data controls in the MVC equivalent: tabular HTML data binding via Razor `foreach` and filter form
- Company-wise placement count
- Printable report/export-to-PDF through browser print

## Note
If the lab's stated technology is specifically ASP.NET Web Forms (`.aspx` and `GridView` server controls), this MVC project does not meet that strict requirement. Your uploaded Practical 8 uses ASP.NET Core MVC; confirm with your teacher whether matching Practical 8's framework is acceptable.

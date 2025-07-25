## HRS(hospital reservation system)
 Patient Appointment Booking is used to organize the appointment scheduling process between patients and medical centers.
# Tech Stack
- Backend: ASP.NET 8 MVC .
- Frontend: Razor Pages, Bootstrap, JavaScript, jQuery .
- Database: SQLite .
# Librariys
- Microsoft.EntityFrameworkCore .
- Microsoft.EntityFrameworkCore.Design .
- Microsoft.EntityFrameworkCore.Sqlite .
- Microsoft.EntityFrameworkCore.Tools .
- Microsoft.Extensions.Configuration .
- Microsoft.Extensions.Configuration.FileExtensions .
- Microsoft.Extensions.Configuration.Json .
- Microsoft.Extensions.DependencyInjection .
# Create database
- instil Librariys suport to SQLite (Use manage nuget).
- Create Tables in Models.Entities .
- Creeate DbContext
- Register DbContext in Program.cs file
- Add ConnectionStrings in appsettings.json
- Create a migration use command(add-migration FirstMagration -o Infrastructure/migration)
- Apply the migration (Create the Database use command update-database) 
# Features
- Login Patient/admin .
- Doctor Registration .
- Doctor Schedule Management .
- Appointment Booking .
# How to run
1. Download the project from GitHub
2. Run the project using Visual Studio
3. Recommendation: Download SQLite from the link https://sqlitebrowser.org/dl/


 






















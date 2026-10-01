# EliteSmile

EliteSmile is a Windows desktop dental clinic management application built with **C#**, **Windows Forms**, **.NET Framework 4.5**, and **SQLite**.

The application provides a simple desktop interface for managing users and patients, with patient reports and database-management functionality.

## Technology Stack

- C#
- Windows Forms
- .NET Framework 4.5
- SQLite via `System.Data.SQLite`
- Crystal Reports for reporting
- Visual Studio project format

## Requirements

### For running the existing build

Windows is required.

The repository contains a pre-built executable under:

`EliteSmile/bin/Debug/EliteSmile.exe`

The application uses a local SQLite database and creates/initializes it automatically when the login window starts.

### For development

Install:

1. **Visual Studio** with .NET Framework desktop development support.
2. **.NET Framework 4.5 Developer/Targeting Pack** (the project targets .NET Framework 4.5).
3. **SAP Crystal Reports for Visual Studio / Crystal Reports runtime** if you need to build or use the Crystal Reports functionality.
4. Any additional third-party component required by the project references, including the `FlashControlV71` component.

> The project is an older .NET Framework application. A modern Visual Studio version can usually open legacy .NET Framework projects, but the required .NET Framework targeting pack and third-party components must be installed separately.

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/hashalshami/EliteSmile.git
cd EliteSmile
```

### 2. Run the existing executable

If you only want to run the application without modifying the source code:

1. Open the `EliteSmile/bin/Debug` directory.
2. Run `EliteSmile.exe`.
3. The login screen will appear.

The application stores its SQLite database in the application's working directory as:

`DataBase.db`

If the database does not exist, EliteSmile creates it automatically and executes:

`query.txt`

to create the required tables and the initial administrator account.

### 3. Default login

The initial database script creates the following account:

| Field | Value |
|---|---|
| Username | `hash` |
| Password | `0000` |
| Role | `Admin` |
| Name | `م. هاشم امين` |

**Change the default password before using the application in a real environment.**

### 4. Open the project in Visual Studio

Open:

`EliteSmile.sln`

Then:

1. Restore/install the required third-party dependencies.
2. Select the **Debug** configuration.
3. Build the solution.
4. Run the project.

The project is configured for **x86** in Debug mode. This is important because the application uses the SQLite provider included with the project.

## Database

EliteSmile uses a local SQLite database.

The database path is determined at runtime from the application's executable directory:

```text
DataBase.db
```

The initialization code is located in:

`EliteSmile/DatabaseInitializer.cs`

The initial schema and seed account are defined in:

`EliteSmile/bin/Debug/query.txt`

The current database schema includes:

- `Users`
- `Patients`

### Resetting the database

To create a fresh database:

1. Close EliteSmile.
2. Delete `DataBase.db` from the application's executable directory.
3. Start the application again.

EliteSmile will recreate the database using `query.txt`.

> Deleting `DataBase.db` permanently removes the locally stored application data. Make a backup first if the database contains real patient records.

## Project Structure

```text
EliteSmile/
├── Classes/              # Shared/helper classes
├── Forms/                # Application windows
├── Models/               # Data models
├── Properties/           # Application settings and resources
├── Resources/            # Application images/icons
├── report/               # Crystal Reports and datasets
├── App.config            # Application configuration
├── DatabaseInitializer.cs
├── Login.cs
├── MainForm.cs
├── Program.cs
└── EliteSmile.csproj
```

Other important repository directories/files:

```text
Package/                  # Included third-party assemblies
Icons/                    # Application icons and images
EliteSmile.sln            # Visual Studio solution
elite_smil.iss            # Inno Setup installer script
```

## Build Notes

The project currently references legacy components that are not fully represented as NuGet dependencies, including:

- Crystal Reports assemblies
- `FlashControlV71`
- `System.Data.SQLite`

If Visual Studio reports missing references, install the corresponding components and then rebuild the solution.

The project currently targets **.NET Framework 4.5**, not modern .NET (6/7/8/9).

## Installer

The repository includes an Inno Setup script:

`elite_smil.iss`

It can be used to create a Windows installer after updating the local source paths in the script to match your development environment.

The current installer script contains machine-specific paths from the original development environment, so these paths should be updated before compiling the installer on another computer.

## Development Workflow

Typical workflow:

```text
Clone repository
      ↓
Open EliteSmile.sln
      ↓
Install required .NET/third-party dependencies
      ↓
Build Debug / x86
      ↓
Run EliteSmile.exe
      ↓
SQLite database is initialized automatically
```

## Important Notes

- This is a Windows desktop application.
- The application uses a local SQLite database; no SQL Server installation is required for the core database functionality.
- The default credentials are included in the database initialization script and should not be used unchanged in production.
- Keep backups of `DataBase.db` when working with real patient data.
- Crystal Reports functionality requires the appropriate Crystal Reports components/runtime.
- The repository contains generated `bin` and `obj` files; for a future cleanup, these generated artifacts can be removed from source control and rebuilt locally.

## License

No license file is currently included in the repository. Unless a license is added, the source code remains subject to the copyright and permissions of its owner.

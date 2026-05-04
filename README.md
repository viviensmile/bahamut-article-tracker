# Bahamut Article Tracker

A small .NET Web API for storing and querying Bahamut forum articles.

This project was originally built as a personal tool and later cleaned up as a public demo.

---

## Overview

This API stores article data from Bahamut and provides basic query endpoints.

It is a simple example focused on structure rather than feature completeness.

---

## Tech Stack

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Swagger (OpenAPI)

---

## Features

* Store article data in a database
* Query articles through API endpoints
* Basic structure for data access and API layers

---

## Project Structure

```txt
src/
  ArtemisShield.Api/
    Controllers/
    Data/
    Models/
    Dtos/
```

---

## Configuration

Before running the project, update the connection string in `appsettings.json`:

```json
{
  "DBConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=Replace_to_your_database;Trusted_Connection=True;",
    "RemoteConnection": "Server=Replace_to_your_server;Database=Replace_to_your_database;User Id=Replace_to_your_user;Password=Replace_to_your_password;Encrypt=True;TrustServerCertificate=True"
  }
}
```

For public use, it is recommended to keep a separate `appsettings.example.json`.

---

## Running the Project

```bash
dotnet restore
dotnet build
dotnet run
```

Swagger UI will be available after the application starts.

---

## Notes

* This project uses simplified data and does not include real production data.
* Some parts are intentionally minimal to keep the example easy to understand.
* You can extend it with background jobs or external data fetching if needed.

---

## Final Thoughts

This is a lightweight project that focuses on clarity and structure.

It is not meant to be a full system, but a clean and practical example.

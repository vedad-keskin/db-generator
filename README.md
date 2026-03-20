# db-generator

A small **ASP.NET Core** solution I used while learning backend development—mainly to practice **Entity Framework Core**, **SQL Server**, and how a **code-first** model turns into a real database (entities, relationships, fluent configuration, and migrations).

The sample domain mixes ideas from a generic app (users, roles, products, cities) with a vehicle/catalog slice (brands, vehicle tiers, vehicles). It is **for experimentation**, not production.

---

## What you can practice here

- **DbContext** wiring and `DbSet<>` exposure  
- **Fluent API** (`IEntityTypeConfiguration<T>`) for constraints, lengths, and relationships  
- **EF Core migrations** as the source of truth for schema evolution  
- **Cascade behavior** (this project sets foreign keys to `DeleteBehavior.NoAction` globally in `OnModelCreating`)  
- Hooking the context into **dependency injection** and a minimal web host  

---

## Stack

| Piece | Notes |
|--------|--------|
| **.NET** | `net7.0` (see `GMS/GMS.csproj`) |
| **EF Core** | 6.x with SQL Server provider |
| **Database** | SQL Server (LocalDB or full instance) |
| **Host** | ASP.NET Core (`GMS` web project) |

---

## Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)  
- SQL Server (e.g. **LocalDB** or a named instance)  
- (Optional) [EF Core tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) for migrations from the CLI  

---

## Getting started

### 1. Clone and restore

```bash
git clone <your-fork-or-remote-url> db-generator
cd db-generator
dotnet restore GMS.sln
```

### 2. Connection string

The app reads **`ConnectionStrings:db1`** (see `GMS/Program.cs`).

Point it at your own database—**do not commit real passwords**. Prefer:

- `dotnet user-secrets` for local development, or  
- environment variables / Azure Key Vault for anything shared  

Example shape (adjust server and database name):

```json
"ConnectionStrings": {
  "db1": "Server=(localdb)\\mssqllocaldb;Database=YourDbName;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### 3. Apply the schema

From the repository root:

```bash
dotnet ef database update --project GMS --startup-project GMS
```

If you add model changes later:

```bash
dotnet ef migrations add YourMigrationName --project GMS --startup-project GMS
dotnet ef database update --project GMS --startup-project GMS
```

### 4. Run the API

```bash
dotnet run --project GMS
```

Use the URL from the console (or `GMS/Properties/launchSettings.json`) to hit the app.

---

## Repository layout

```
db-generator/
├── GMS.sln
├── GMS/
│   ├── Data/
│   │   └── ApplicationDbContext.cs    # DbContext + OnModelCreating
│   ├── Entities/Models/               # POCO entities
│   ├── Configuration/                 # Fluent API configurations
│   ├── Migrations/                    # Generated EF migrations
│   ├── Program.cs                     # Host, DI, DbContext registration
│   └── appsettings.json               # Configuration (keep secrets out of git)
└── README.md
```

---

## Notes for future you

- Some types still live under the **`eCommerce.*`** namespaces from an earlier course/template; the **solution name** is **GMS**. Renaming namespaces is optional cleanup if you want everything aligned.  
- **Swagger** packages are referenced; if the UI does not start, ensure `AddSwaggerGen` / OpenAPI are registered in `Program.cs` to match `UseSwagger` / `UseSwaggerUI`.  

---

## License

MIT — see [LICENSE](LICENSE).

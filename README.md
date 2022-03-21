# Lunar.API

This is an example .NET 6 API project that integrates with CosmosDB via an Entity Framework Provider.

## Setup

All you need to do is a create a new database in CosmosDB called `lunar-db` (or change the name in `Program.cs`).
Don't worry about containers - our code takes care of those.

## Notes about integration

**Program.cs**
These lines take our database agnostic database context, and provides our local CosmosDB connection strings. You could easily swap out this section and connect to a SQL Server or an in memory database!

```csharp
builder.Services.AddDbContext<LunarDbContext>(options =>
    options.UseCosmos(
        accountEndpoint: "https://localhost:8081",
        accountKey: "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
        databaseName: "lunar-db"
    )
);
```

These lines will grab an instance of our `DbContext` and make sure the database is created - this is where the containers will be automatically created based on our models.

```csharp
var context = builder.Services.BuildServiceProvider().GetService<LunarDbContext>();
context.Database.EnsureCreated();
```

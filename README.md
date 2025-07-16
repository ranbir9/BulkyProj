Section 2: 
- Create Database
      Use dotnet cli tool, run command 'dotnet ef database update' where the csproj file is
- Create Category Table
      dotnet ef migrations add AddCategoryTableToDb
      new migration is added
      now update database to apply it
      'dotnet ef database update'

    Summary Migrations:
      1. Create Model
      2. have properties
      3. in ApplicationDbContext, we have to create a DbSet for that
      4. In console, using dotnet ef cli,
          add migration
          run update databse command, pushes migrations to database
          Categories table is created in database

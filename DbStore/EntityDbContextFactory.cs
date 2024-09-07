using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace test_dotnet_app.DbStore;

public class EntityDbContextFactory : IDesignTimeDbContextFactory<EntityDbContext>
{
   public EntityDbContext CreateDbContext(string[] args)
   {
       var configuration = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
       .Build();
       var optionsBuilder = new DbContextOptionsBuilder<EntityDbContext>()
    //    .UseInMemoryDatabase("EmployeeDB");
       // UseSqlServer(configuration.GetConnectionString("sqlConnection"))
       .UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;");
       return new EntityDbContext(optionsBuilder.Options);
   }
}

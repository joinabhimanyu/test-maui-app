using Microsoft.EntityFrameworkCore;
using test_webapi_app.Entities;

namespace test_webapi_app.DbStore;

public static class DocumentEntityRelations
{
    public static void ConfigureDocumentEntityRelations(this ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Employee>().Ignore("Department");
        modelBuilder.Entity<Department>()
            .HasMany(dep => dep.Employees)
            .WithOne(emp => emp.Department)
            .HasForeignKey(emp => emp.DepartmentId)
            .IsRequired();
            
        modelBuilder.Entity<Department>()
        .Navigation(a => a.Employees)
        .AutoInclude(false);
    }
}

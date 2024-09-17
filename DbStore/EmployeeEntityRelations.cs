using Microsoft.EntityFrameworkCore;
using test_webapi_app.Entities;

namespace test_webapi_app.DbStore;

public static class EmployeeEntityRelations
{
    public static void ConfigureEmployeeEntityRelations(this ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Department>().Ignore("Employees");
        modelBuilder.Entity<Employee>()
            .HasOne(emp=>emp.Department)
            .WithMany(dept=>dept.Employees)
            .HasForeignKey(emp=>emp.DepartmentId)
            .IsRequired();

        modelBuilder.Entity<Employee>()
        .Navigation(a=>a.Department)
        .AutoInclude(false);
    }
}

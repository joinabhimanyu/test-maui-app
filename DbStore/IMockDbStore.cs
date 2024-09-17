using test_webapi_app.Entities;

namespace test_webapi_app.DbStore;

public interface IMockDbStore
{
    public List<Employee>? Employees { get; set; }
    public List<Department>? Departments { get; set; }
    void LoadEmployeesForDepartment(ref Department? department);
    void LoadDepartmentForEmployee(ref Employee? employee);
}

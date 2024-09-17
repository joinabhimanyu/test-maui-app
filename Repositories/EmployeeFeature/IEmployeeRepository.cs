using test_webapi_app.DTO;
using test_webapi_app.Entities;

namespace test_webapi_app.Repositories.EmployeeFeature;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync(bool include);
    Task<Employee> GetByIdAsync(int id, bool include);
    Task<IEnumerable<Employee>?> SearchAsync(List<SearchParam>? searchParams, bool include);
    Task AddAsync(Employee employee);
    Task DeleteAsync(int id);
    Task UpdateAsync(Employee employee);
}

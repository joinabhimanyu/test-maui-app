using test_webapi_app.DTO;
using test_webapi_app.DTO.EmployeeFeature;

namespace test_webapi_app.Services.EmployeeFeature;

public interface IEmployeeService
{
    Task<IEnumerable<EmployeeDto>> GetAllAsync(bool include);
    Task<EmployeeDto?> GetByIdAsync(int id, bool include);
    Task<IEnumerable<EmployeeDto>?> SearchAsync(List<SearchParam>? searchParams, bool include);
    Task AddAsync(EmployeeDto employee);
    Task DeleteAsync(int id);
    Task UpdateAsync(EmployeeDto employee);
}

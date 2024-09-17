using test_webapi_app.DTO;
using test_webapi_app.Entities;

namespace test_webapi_app.Repositories.DepartmentFeature;

public interface IDepartmentRepository
{
    Task<IEnumerable<Department>> GetAllAsync(bool include);
    Task<Department> GetByIdAsync(int id, bool include);
    Task<IEnumerable<Department>?> SearchAsync(List<SearchParam>? searchParams, bool include);
    Task AddAsync(Department department);
    Task UpdateAsync(Department department);
    Task DeleteAsync(int id);
}

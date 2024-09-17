using System.ComponentModel.DataAnnotations;
using test_webapi_app.DTO.EmployeeFeature;

namespace test_webapi_app.DTO.DepartmentFeature;

public class DepartmentDto : BaseDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Department Name is required")]
    public string? Name { get; set; }

    public IEnumerable<EmployeeDto>? Employees { get; set; }

    public DepartmentDto()
    {
    }
    public DepartmentDto(int id, string name, List<EmployeeDto> employees,DateTime createdAt, DateTime updatedAt) //
        :base(createdAt, updatedAt)
    {
        Id = id;
        Name = name;
        Employees = employees;
    }
}
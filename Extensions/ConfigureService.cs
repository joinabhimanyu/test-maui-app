using test_webapi_app.Services.Authentication;
using test_webapi_app.Services.DepartmentFeature;
using test_webapi_app.Services.EmployeeFeature;

namespace test_webapi_app.Extensions;

public static class ConfigureServiceWrapper
{
    public static void ConfigureService(this IServiceCollection services)
    {
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
    }
}

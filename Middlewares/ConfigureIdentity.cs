using Microsoft.AspNetCore.Identity;
using test_webapi_app.DbStore;
using test_webapi_app.Entities;

namespace test_webapi_app.Middlewares;

public static class ConfigureIdentityWrapper
{
    public static void ConfigureIdentity(this IServiceCollection services)
    {
        var builder=services.AddIdentity<User, IdentityRole>(options=>{
            // set password options
            options.Password.RequireDigit=true;
            options.Password.RequireLowercase=false;
            options.Password.RequireUppercase=false;
            options.Password.RequireNonAlphanumeric=false;
            options.Password.RequiredLength=10;
            options.User.RequireUniqueEmail=true;
        })
        .AddEntityFrameworkStores<EntityDbContext>()
        .AddDefaultTokenProviders();
    }
}

using System;
using test_maui_app.ViewModels;

namespace test_maui_app.Extensions;

public static class ConfigureExtensionsWrapper
{
    public static void ConfigureExtensions(this IServiceCollection services)
    {
        services.AddTransient<MainPageViewModel>();
    }
}

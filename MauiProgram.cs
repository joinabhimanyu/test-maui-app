using DotNet.Meteor.HotReload.Plugin;
using Microsoft.Extensions.Logging;
using test_maui_app.Extensions;

namespace test_maui_app
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
#if DEBUG
                .EnableHotReload()
#endif
                .ConfigureFonts(fonts =>
                {
                    // JetBrains latin font settings
                    fonts.AddFont("jetbrains-mono-latin-100-normal.ttf", "JetbrainsMonoLatin100NormalRegular");
                    fonts.AddFont("jetbrains-mono-latin-200-normal.ttf", "JetbrainsMonoLatin200NormalRegular");
                    fonts.AddFont("jetbrains-mono-latin-300-normal.ttf", "JetbrainsMonoLatin300NormalRegular");
                    fonts.AddFont("jetbrains-mono-latin-400-normal.ttf", "JetbrainsMonoLatin400NormalRegular");
                    fonts.AddFont("jetbrains-mono-latin-500-normal.ttf", "JetbrainsMonoLatin500NormalRegular");
                    fonts.AddFont("jetbrains-mono-latin-600-normal.ttf", "JetbrainsMonoLatin600NormalRegular");
                    fonts.AddFont("jetbrains-mono-latin-700-normal.ttf", "JetbrainsMonoLatin700NormalRegular");
                    fonts.AddFont("jetbrains-mono-latin-800-normal.ttf", "JetbrainsMonoLatin800NormalRegular");

                    // RobotoMono font settings
                    fonts.AddFont("RobotoMono-Thin.ttf", "RobotoMono-Thin");
                    fonts.AddFont("RobotoMono-SemiBold.ttf", "RobotoMono-SemiBold");
                    fonts.AddFont("RobotoMono-Regular.ttf", "RobotoMono-Regular");
                    fonts.AddFont("RobotoMono-Medium.ttf", "RobotoMono-Medium");
                    fonts.AddFont("RobotoMono-Light.ttf", "RobotoMono-Light");
                    fonts.AddFont("RobotoMono-ExtraLight.ttf", "RobotoMono-ExtraLight");
                    fonts.AddFont("RobotoMono-Bold.ttf", "RobotoMono-Bold");
                    // IBM Plex Latin font settings
                    fonts.AddFont("ibm-plex-sans-latin-100-normal.ttf", "IBMPlexSansLatin100NormalRegular");
                    fonts.AddFont("ibm-plex-sans-latin-200-normal.ttf", "IBMPlexSansLatin200NormalRegular");
                    fonts.AddFont("ibm-plex-sans-latin-300-normal.ttf", "IBMPlexSansLatin300NormalRegular");
                    fonts.AddFont("ibm-plex-sans-latin-400-normal.ttf", "IBMPlexSansLatin400NormalRegular");
                    fonts.AddFont("ibm-plex-sans-latin-500-normal.ttf", "IBMPlexSansLatin500NormalRegular");
                    fonts.AddFont("ibm-plex-sans-latin-600-normal.ttf", "IBMPlexSansLatin600NormalRegular");
                    fonts.AddFont("ibm-plex-sans-latin-700-normal.ttf", "IBMPlexSansLatin700NormalRegular");

                    // Material Icons settings                    
                    fonts.AddFont("material-icons-latin-400-normal.ttf", "MaterialIconsLatinRegular");
                    fonts.AddFont("material-icons-outlined-latin-400-normal.ttf", "MaterialIconsOutlinedLatinRegular");
                    fonts.AddFont("material-icons-round-latin-400-normal.ttf", "MaterialIconsRoundLatinRegular");

                    // Open Sans Font Settings
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.ConfigureExtensions();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

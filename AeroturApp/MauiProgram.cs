using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using AeroturApp.Services;
using AeroturApp.Models.ViewModels;
using AeroturApp.Views;

namespace AeroturApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<WebAPIClient>();
            //builder.Services.AddSingleton<IataCodesService>();

            builder.Services.AddTransient<SearchResultsViewModel>();
            builder.Services.AddTransient<SearchResultPage>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }


    }
}

using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using AeroturApp.Services;
using AeroturApp.Models.ViewModels;
using AeroturApp.Views;
using Mopups.Hosting;

#if ANDROID || IOS
using DevExpress.Maui;
#endif
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
#if ANDROID || IOS
                .UseDevExpress()               
#endif
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.ConfigureMopups();
//#if ANDROID || IOS
////            DevExpress.Maui.CollectionView.Initializer.Init();
//#endif
            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddSingleton<WebAPIService>();
            builder.Services.AddSingleton<IataCodesService>();

            builder.Services.AddTransient<SearchResultsViewModel>();
            builder.Services.AddTransient<ResultsPage>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();


#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }


    }
}

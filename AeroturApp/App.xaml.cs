using AeroturApp.Views;
namespace AeroturApp
{
    public partial class App : Application
    {
        public App(AppShell main)
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SearchResultPage), typeof(SearchResultPage));
            Routing.RegisterRoute(nameof(Views.MainPage), typeof(MainPage));
            MainPage = main;

        }
    }
}

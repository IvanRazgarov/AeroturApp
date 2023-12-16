using AeroturApp.Views;
namespace AeroturApp
{
    public partial class App : Application
    {
        public App(AppShell main)
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ResultsPage), typeof(ResultsPage));
            Routing.RegisterRoute(nameof(Views.MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(PaymentPage), typeof(PaymentPage));
            MainPage = main;

        }
    }
}

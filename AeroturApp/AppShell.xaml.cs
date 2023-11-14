using AeroturApp.Views;

namespace AeroturApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SearchResultPage), typeof(SearchResultPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}

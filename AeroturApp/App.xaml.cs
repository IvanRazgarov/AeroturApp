using AeroturApp.Services;
namespace AeroturApp
{
    public partial class App : Application
    {
        public App(AppShell shell)
        {
            InitializeComponent();

            MainPage = shell;

        }
    }
}

using AeroturApp.Services;
namespace AeroturApp
{
    public partial class App : Application
    {
        //public WebAPIClient Client = new WebAPIClient();
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //WebAPIClient();

            //var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
            //using(Stream stream = assembly.GetManifestResourceStream($"AeroturApp.Services.{StaticDatabase.DatabaseFilename}"))
            //{
            //    using (MemoryStream  memoryStream = new MemoryStream())
            //    {
            //        stream.CopyTo(memoryStream);
            //        File.WriteAllBytes(StaticDatabase.DatabasePath, memoryStream.ToArray());    
            //    }
            //}
        }
    }
}

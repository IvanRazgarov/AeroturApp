using AeroturApp.Services;
using AeroturApp.Views;
using System.Reflection;
namespace AeroturApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

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

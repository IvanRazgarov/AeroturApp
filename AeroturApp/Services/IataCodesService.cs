using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroturApp.Services;

class IataCodesService
{
    async Task LoadCitiesIATA()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("cities.txt");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();
    }
    async void SaveCitiesIATA(string contents)
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("cities.txt");
        using var writer = new StreamWriter(stream);

        await writer.WriteAsync(contents);
    }
}

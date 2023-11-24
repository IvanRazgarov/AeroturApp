using AeroturApp.Models.DataModels;
using CommunityToolkit.Maui.Core.Extensions;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace AeroturApp.Services;

public class IataCodesService : IDisposable
{
    public static List<IATA_City> cities { get; set; }
    public static List<IATA_Airport> airports { get; set; }

    private WebAPIClient client;
    
    private static DateTime? lastUpdate = DateTime.Parse(SecureStorage.GetAsync("LastIATAUpdate").Result);

    private string path_cities = "cities.json";//Path.Combine(FileSystem.Current.AppDataDirectory, "cities.json");
    private string path_airports = "airports.json"; //Path.Combine(FileSystem.Current.AppDataDirectory, "airports.json");
    public IataCodesService(WebAPIClient cli)
    {
        client = cli;
        //cities = LoadContentIATA<IATA_City>(path_cities).Result;
        //airports = LoadContentIATA<IATA_Airport>(path_airports).Result;
    }
    async Task<List<T>> LoadContentIATA<T>(string path)
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync(path);

        var result = await JsonSerializer.DeserializeAsync<List<T>>(stream);
        return result;
    }
    async void SaveContentIATA<T>(List<T> contents, string path)
    {
        if (contents != null)
        {
            using var stream = File.Create(path);
            await JsonSerializer.SerializeAsync(stream, contents);
        }
    }

    public void Dispose()
    {
        SaveContentIATA(cities, path_cities);
        SaveContentIATA(airports, path_airports);
    }

    public async void UpdateLocalCodes()
    {
        var delta = lastUpdate - DateTime.Now;
        if (delta.Value.TotalDays < 30) return;
        await SecureStorage.SetAsync(DateTime.Now.ToString(), "LastIATAUpdate");

        cities = await client.GetIATAFromNet<IATA_City>();
        airports = await client.GetIATAFromNet<IATA_Airport>();
    }

    public ValueTask<ObservableCollection<IATA_City>> GetCityCodeByPart(string part)
    {
        return new ValueTask<ObservableCollection<IATA_City>>(cities.Where((IATA_City s)=> s.name.Contains(part)).ToObservableCollection());
    }
    public ValueTask<ObservableCollection<IATA_Airport>> GetAirportCodeByPart(string part)
    {
        return new ValueTask<ObservableCollection<IATA_Airport>>(airports.Where((IATA_Airport s) => s.name.Contains(part)).ToObservableCollection());
    }
}

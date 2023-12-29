using AeroturApp.Models.DataModels;
using CommunityToolkit.Mvvm.Messaging;
using System.Text.Json;

namespace AeroturApp.Services;

public class IataCodesService 
{
    private DateTime lastUpdate = DateTime.MinValue;
    private static WebAPIClient client;

    private string fullPathCities = Path.Combine(FileSystem.Current.CacheDirectory, "Cities_IATA");
    private string fullPathAirports = Path.Combine(FileSystem.Current.CacheDirectory, "Airports_IATA");

    private static List<IATA_Citi> cities =new();
    private static List<IATA_Airport> airports = new();

    public List<IATA_Citi> Cities { get { return cities; } }
    public List<IATA_Airport> Airports { get { return airports; } }

    public IataCodesService(WebAPIClient web)
    {
        client = web;
        Task.Run(LoadIATA);
    }
    private async Task LoadIATA()
    {
        try
        {
            lastUpdate = DateTime.Parse(Preferences.Default.Get(nameof(lastUpdate), DateTime.Now.ToString()));

            if ((DateTime.Now - lastUpdate).TotalDays <= 30)
            {
                var citiesJson = await File.ReadAllTextAsync(fullPathCities);
                var airportsJson = await File.ReadAllTextAsync(fullPathAirports);

                cities = JsonSerializer.Deserialize<List<IATA_Citi>>(citiesJson);
                airports = JsonSerializer.Deserialize<List<IATA_Airport>>(airportsJson);

            }
        }
        catch
        {
            UpdateIATA();
            WeakReferenceMessenger.Default.Send(new LoadingConfirmationMessage(true));
            await SaveIATA();
        }
    }
    private async Task SaveIATA()
    {
        var citiesJson = JsonSerializer.Serialize(cities);
        var airportsJson = JsonSerializer.Serialize(airports);

        await File.WriteAllTextAsync(fullPathCities, citiesJson);
        await File.WriteAllTextAsync(fullPathAirports, airportsJson);

        Preferences.Default.Set(nameof(lastUpdate), lastUpdate);
    }
    public void UpdateIATA()
    {

        cities = client.GetIATAFromNet<IATA_Citi>().GetAwaiter().GetResult();
        airports = client.GetIATAFromNet<IATA_Airport>().GetAwaiter().GetResult();
        lastUpdate = DateTime.Now;

    }
    public static string GetCitiName(string code)
    {
        return cities.Find(x=>x.code == code).name;
    }
    public static string GetCitiCode(string name)
    {
        return cities.Find(x => x.name == name).code;
    }
    public static IATA_Citi GetCitiIATA(string code)
    {
        return cities.Find(x =>x.code==code);
    }
    public static IATA_Citi GetCitiIATA(float lat, float lon)
    {
        return cities.Find(x => x.coordinates["lat"]==lat & x.coordinates["lon"]==lon);
    }
    public static string GetAirportName(string code)
    {
        return airports.Find((x) => x.code == code).name;   
    }
    public static string GetAirportCode(string name)
    {
        return airports.Find(x => x.name == name).code;
    }
    public static IATA_Airport GetAirportIATA(string code)
    {
        return airports.Find((x) => x.code == code); 
    }
    public static IATA_Airport GetAirportIATA(float lat, float lon)
    {
        return airports.Find(x => x.coordinates["lat"] == lat & x.coordinates["lon"] == lon);
    }
}

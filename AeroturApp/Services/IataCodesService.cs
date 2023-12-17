using AeroturApp.Models.DataModels;
using System.Text.Json;

namespace AeroturApp.Services;

public class IataCodesService 
{
    private DateTime lastUpdate = DateTime.MinValue;
    private static WebAPIClient client;

    private string fullPathCities = Path.Combine(FileSystem.Current.AppDataDirectory, "Cities_IATA");
    private string fullPathAirports = Path.Combine(FileSystem.Current.AppDataDirectory, "Airports_IATA");

    private List<IATA_Citi> cities;
    private List<IATA_Airport> airports;

    public List<IATA_Citi> Cities { get { return cities; } }
    public List<IATA_Airport> Airports { get { return airports; } }

    public IataCodesService(WebAPIClient web)
    {
        client = web;
        //Task.Run(LoadIATA);
        //Task.Run(UpdateIATA);
    }
    private async Task LoadIATA()
    {
        try 
        { 
        var citiesJson = await File.ReadAllTextAsync(fullPathCities);
        var airportsJson = await File.ReadAllTextAsync(fullPathAirports);

        cities = JsonSerializer.Deserialize<List<IATA_Citi>>(citiesJson);
        airports = JsonSerializer.Deserialize<List<IATA_Airport>>(airportsJson);

        lastUpdate = DateTime.Parse(Preferences.Default.Get(nameof(lastUpdate), DateTime.Now.ToString()));
        }
        catch
        {
            await UpdateIATA();
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
    public string GetCitiName(string code)
    {
        return cities.Find((x)=>x.code == code).name;
    }
    public IATA_Citi GetCitiIATA(string code)
    {
        return cities.Find((x) =>x.code==code);
    }
    public string GetAirportName(string code)
    {
        return airports.Find((x) => x.code == code).name;   
    }
    public IATA_Airport GetAirportIATA(string code)
    {
        return airports.Find((x) => x.code == code); 
    }
    public async Task UpdateIATA()
    {
        if ((DateTime.Now - lastUpdate).TotalDays >= 30)
        {
            cities = await client.GetIATAFromNet<IATA_Citi>();
            airports = await client.GetIATAFromNet<IATA_Airport>();
            await SaveIATA();
            lastUpdate = DateTime.Now;
        }
    }
}

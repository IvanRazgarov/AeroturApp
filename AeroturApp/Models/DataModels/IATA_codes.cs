namespace AeroturApp.Models.DataModels;
public class IATA_Citi
{
    public Dictionary<string, string> name_translations { get; set; }
    public Dictionary<string, string> cases { get; set; }
    public string country_code { get; set; }
    public string code { get; set; }
    public string time_zone { get; set; }
    public string name { get; set; }
    public Dictionary<string, float> coordinates { get; set; }
}

public class IATA_Airport
{
    public Dictionary<string, string> name_translations { get; set; }
    public string city_code { get; set; }
    public string country_code { get; set; }
    public string time_zone { get; set; }
    public string code { get; set; }
    public string iata_type { get; set; }
    public string name { get; set; }
    public Dictionary<string, float> coordinates { get; set; }
    public bool flightable { get; set; }
}



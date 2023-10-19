using SQLite;

namespace AeroturApp.Models.DataModels
{
    class AirportCard
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public Dictionary<string, string> NameTranslation { get; set; }
        public string CityCode { get; set; }
        public string CountryCode { get; set; }
        public string TimeZone {  get; set; }
        public string IATACode { get; set; }
        public string IATAType { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int> Coordinates { get; set; }
        public bool Flightable { get; set; } = true;
    }

}

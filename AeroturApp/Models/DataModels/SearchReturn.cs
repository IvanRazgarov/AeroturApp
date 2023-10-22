using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroturApp.Models.DataModels
{
    public class SearchReturn
    {
        public string request_id { get; set; }
        public Variant[] variants { get; set; }
        public Info info { get; set; }
        public Tariffs tariffs { get; set; }
        public Airlines airlines { get; set; }
        public Airports airports { get; set; }
        public Aircraft aircraft { get; set; }
    }

    public class Info
    {
        public string requestLog { get; set; }
        public string responseLog { get; set; }
        public int parsed_flight_count { get; set; }
        public Msg[] msg { get; set; }
    }

    public class Msg
    {
        public string level { get; set; }
        public string code { get; set; }
        public string message { get; set; }
    }

    public class Tariffs
    {
        public Tarrif _5NIBSOW { get; set; }
        public Tarrif _5NILTOW { get; set; }
        public Tarrif _5NISTOW { get; set; }
        public Tarrif DPOAD { get; set; }
        public Tarrif DPOALL { get; set; }
        public Tarrif DPOMX { get; set; }
        public Tarrif DPXAD { get; set; }
        public Tarrif DPXALL { get; set; }
        public Tarrif DPXMX { get; set; }
        public Tarrif EKYRTRU7 { get; set; }
        public Tarrif HYM12MRTNB { get; set; }
        public Tarrif S7OBSRT { get; set; }
        public Tarrif S7OPLRT { get; set; }
        public Tarrif S7OSTRT { get; set; }
        public Tarrif S7QBSRT { get; set; }
        public Tarrif S7QPLRT { get; set; }
        public Tarrif S7QSTRT { get; set; }
        public Tarrif S7TPLRT { get; set; }
        public Tarrif S7TSTRT { get; set; }
        public Tarrif S7TBSRT { get; set; }
        public Tarrif SUGNBR { get; set; }
        public Tarrif SUNNBR { get; set; }
        public Tarrif SURNBR { get; set; }
        public Tarrif U6NECRT { get; set; }
        public Tarrif U6NFLRT { get; set; }
        public Tarrif U6NPRRT { get; set; }
        public Tarrif U6ZBSRT { get; set; }
        public Tarrif UTHFLEXRT { get; set; }
        public Tarrif UTHLTRT { get; set; }
        public Tarrif UTHSTDRT { get; set; }
        public Tarrif UTKFLEXRT { get; set; }
        public Tarrif UTKLTRT { get; set; }
        public Tarrif UTKSTDRT { get; set; }
        public Tarrif DPPROMOALL { get; set; }
        public Tarrif DPPAD { get; set; }
        public Tarrif DPPMX { get; set; }
        public Tarrif S7NBSRT { get; set; }
        public Tarrif S7NSTRT { get; set; }
        public Tarrif S7NPLRT { get; set; }
        public Tarrif _7RLCSLTOW { get; set; }
        public Tarrif _7RUCSLTOW { get; set; }
    }

    public class Tarrif
    {
        public string id { get; set; }
        public string airline_code { get; set; }
        public string tariff_code { get; set; }
        public string tariff_family_code { get; set; }
        public string tariff_family_name { get; set; }
        public string type { get; set; }
        public bool is_fixed { get; set; }
        public bool is_gds { get; set; }
        public string carry_on_measure { get; set; }
        public string carry_on_value { get; set; }
        public string baggage_measure { get; set; }
        public string baggage_value { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public bool is_baggage { get; set; }
        public string baggage_state { get; set; }
        public Description[] descriptions { get; set; }
    }

    public class Description
    {
        public string id { get; set; }
        public string tariff_id { get; set; }
        public string code { get; set; }
        public string locale { get; set; }
        public string need_to_pay { get; set; }
        public string description_short { get; set; }
        public string description_long { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
    }

    public class Airlines
    {
        public Company SU { get; set; }
        public Company S7 { get; set; }
        public Company UT { get; set; }
        public Company U6 { get; set; }
        public Company _5N { get; set; }
        public Company _7R { get; set; }
        public Company DP { get; set; }
        public Company EK { get; set; }
        public Company HY { get; set; }
    }

    public class Company
    {
        public int id { get; set; }
        public string code { get; set; }
        public string logo { get; set; }
        public object site { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public bool is_improved_logo { get; set; }
        public int order { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public string logo_url { get; set; }
        public CompanyAliases[] names { get; set; }
    }

    public class CompanyAliases
    {
        public int id { get; set; }
        public string locale { get; set; }
        public string field { get; set; }
        public string value { get; set; }
        public object text { get; set; }
        public string ownerable_type { get; set; }
        public int ownerable_id { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
    }

    public class Airports
    {
        public Airport TAS { get; set; }
        public Airport DME { get; set; }
        public Airport VKO { get; set; }
        public Airport LED { get; set; }
        public Airport SVO { get; set; }
        public Airport DXB { get; set; }
    }

    public class Airport
    {
        public int id { get; set; }
        public string code { get; set; }
        public string airport_type { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string timezone { get; set; }
        public int order { get; set; }
        public int city_id { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public AirportAliases[] names { get; set; }
        public City city { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string code { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public int order { get; set; }
        public int country_id { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public CityAliases[] names { get; set; }
        public Country country { get; set; }
    }

    public class Country
    {
        public int id { get; set; }
        public string code { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public int order { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public CountryAliases[] names { get; set; }
    }

    public class CountryAliases
    {
        public int id { get; set; }
        public string locale { get; set; }
        public string field { get; set; }
        public string value { get; set; }
        public object text { get; set; }
        public string ownerable_type { get; set; }
        public int ownerable_id { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
    }

    public class CityAliases
    {
        public int id { get; set; }
        public string locale { get; set; }
        public string field { get; set; }
        public string value { get; set; }
        public object text { get; set; }
        public string ownerable_type { get; set; }
        public int ownerable_id { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
    }

    public class AirportAliases
    {
        public int id { get; set; }
        public string locale { get; set; }
        public string field { get; set; }
        public string value { get; set; }
        public object text { get; set; }
        public string ownerable_type { get; set; }
        public int ownerable_id { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
    }

    public class Aircraft
    {
        public GenericAircraft SU9 { get; set; }
        public GenericAircraft _789 { get; set; }
        public GenericAircraft _77W { get; set; }
        public GenericAircraft _763 { get; set; }
        public GenericAircraft _73H { get; set; }
        public GenericAircraft _738 { get; set; }
        public GenericAircraft _737 { get; set; }
        public GenericAircraft _388 { get; set; }
        public GenericAircraft _32N { get; set; }
        public GenericAircraft _32B { get; set; }
        public GenericAircraft _32A { get; set; }
        public GenericAircraft _321 { get; set; }
        public GenericAircraft _320 { get; set; }
        public GenericAircraft _319 { get; set; }
        public GenericAircraft _32Q { get; set; }
    }

    public class GenericAircraft
    {
        public int id { get; set; }
        public string code { get; set; }
        public object code_icao { get; set; }
        public string aircraft_type { get; set; }
        public string name { get; set; }
        public object manufacturer { get; set; }
        public object aircraft_model { get; set; }
        public object site { get; set; }
        public object img { get; set; }
        public bool is_fixed { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public object img_url { get; set; }
    }
    
    public class Variant
    {
        public string flight_id { get; set; }
        public string booking_url { get; set; }
        public bool is_low_cost { get; set; }
        public bool is_charter { get; set; }
        public bool is_regular { get; set; }
        public int? seats { get; set; }
        public int? expected_ticket_count { get; set; }
        public Supplier[] suppliers { get; set; }
        public string[] price_detail { get; set; }
        public int price { get; set; }
        public string currency { get; set; }
        public Segment[] segments { get; set; }
        public string ident { get; set; }
    }
    public class Supplier
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class Segment
    {
        public int leg { get; set; }
        public string flight_number { get; set; }
        public string aircraft_type { get; set; }
        public string marketing_company { get; set; }
        public string operating_company { get; set; }
        public string departure_date_time { get; set; }
        public string arrival_date_time { get; set; }
        public bool is_not_airplane { get; set; }
        public int flight_time { get; set; }
        public object[] stop_points { get; set; }
        public string departure_airport { get; set; }
        public string departure_terminal { get; set; }
        public string departure_utc { get; set; }
        public string arrival_airport { get; set; }
        public string arrival_terminal { get; set; }
        public string arrival_utc { get; set; }
        public string booking_class { get; set; }
        public string booking_class_code { get; set; }
        public string refundable { get; set; }
        public bool isPrivateFare { get; set; }
        public string validating_company { get; set; }
        public string[] tariffIds { get; set; }
        public string flight_number_full { get; set; }
    }
}

﻿

using AeroturApp.Services;

namespace AeroturApp.Models.DataModels;


public class SearchReturn
{
    public string request_id { get; set; }
    public bool is_valid { get; set; } = true;
    public string error_msg { get; set; }
    public List<Variant> variants { get; set; }
    public Info info { get; set; }
    public static Dictionary<string,GenericCompany> airlines { get; set; }
    public static Dictionary<string,GenericAirport> airports { get; set; }
    public static Dictionary<string,GenericAircraft> aircraft { get; set; }
}

public class Info
{
    public string requestLog { get; set; }
    public string responseLog { get; set; }
    public int parsed_flight_count { get; set; }
    public bool is_ext_mode { get; set; }
    public List<Msg> msg { get; set; }
}
public class Msg
{
    public string level { get; set; }
    public string code { get; set; }
    public string message { get; set; }
}
public class Name
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
public class GenericCompany
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
    public List<Name> names { get; set; }
}
public class GenericAirport
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
    public List<Name> names { get; set; }
    public GenericCity city { get; set; }
}
public class GenericCity
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
    public List<Name> names { get; set; }
    public GenericCountry country { get; set; }
}
public class GenericCountry
{
    public int id { get; set; }
    public string code { get; set; }
    public bool is_active { get; set; }
    public bool is_fixed { get; set; }
    public int order { get; set; }
    public object created_at { get; set; }
    public object updated_at { get; set; }
    public string name { get; set; }
    public List<Name> names { get; set; }
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
    public bool is_expanded { get; set; }
    public string flight_id { get; set; }
    public string ident { get; set; }
    public string booking_url { get; set; }
    public string flight_type { get; set; }
    public string flight_direction_type { get; set; }
    public bool is_direct_flight { get; set; }
    public int? seats { get; set; }
    public int? expected_ticket_count { get; set; }
    public string supplier_name { get; set; }
    public string supplier_id { get; set; }
    public int price { get; set; }
    public string currency { get; set; }
    public List<string> price_detail { get; set; }
    public Baggage baggage { get; set; }
    public Baggage carry_on { get; set; }
    public TiketActions exchange { get; set; }
    public TiketActions refund { get; set; }
    public List<Leg> legs { get; set; }
    public string arrival_city { get                
        {
            return legs.Last().segments.Last().aa;
        }
    }
    public DateTime arrival_date_time { get
        {
            return legs.Last().segments.Last().adt;
        } 
    }
    public TimeSpan delta_travel_time { get
        {
            var time = legs.Last().segments.Last().adt - legs[0].segments[0].ddt;
            return time;
        } 
    }

}
public class Baggage
{
    public bool is_baggage { get; set; }
    public int value { get; set; }
    public string measure { get; set; }
    public object[] descriptions { get; set; }
}
public class TiketActions
{
    public string type { get; set; }
    public object[] descriptions { get; set; }
}
public class Leg
{
    public List<Segment> segments { get; set; }
    public Baggage baggage { get; set; }
    public Baggage carry_on { get; set; }
    public TiketActions exchange { get; set; }
    public TiketActions refund { get; set; }
}
public class Segment
{
    public bool is_last { get; set; } = false;
    public string ident { get; set; }
    public string flight_number { get; set; }
    public string flight_number_full { get; set; }
    public string aircraft_type { get; set; }
    public string segment_type { get; set; }
    public int flight_time { get; set; }
    public string validating_airline { get; set; }
    public string operating_company { get; set; }
    public string operating_company_logo { get; set; }
    public string marketing_company { get; set; }
    public string marketing_company_logo { get; set; }
    public TimeSpan travel_time { get => adt - ddt; }
    public DateTime ddt { get; set; }
    public string departure_date_time {  set
        {
            ddt = DateTime.Parse(value);
        }
    }
    public string da { get => IataCodesService.GetAirportName(departure_airport); }
    public string departure_airport { get; set; }
    public string departure_terminal { get; set; }
    public string departure_utc { get; set; }
    public DateTime adt { get; set; }
    public string arrival_date_time { set
        {
            adt = DateTime.Parse(value);
        }
    }
    public string aa { get => IataCodesService.GetAirportName(arrival_airport); }
    public string arrival_airport { get; set; }
    public string arrival_terminal { get; set; }
    public string arrival_utc { get; set; }
    public List<object> stop_points { get; set; }
    public Tariff tariff { get; set; }
}
public class Tariff
{
    public string code { get; set; }
    public string booking_class { get; set; }
    public string booking_class_code { get; set; }
    public bool is_private_fare { get; set; }
    public Baggage baggage { get; set; }
    public Baggage carry_on { get; set; }
    public TiketActions exchange { get; set; }
    public TiketActions refund { get; set; }
    public List<string> logs { get; set; }
}

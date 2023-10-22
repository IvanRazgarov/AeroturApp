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
        public _5NIBSOW _5NIBSOW { get; set; }
        public _5NILTOW _5NILTOW { get; set; }
        public _5NISTOW _5NISTOW { get; set; }
        public DPOAD DPOAD { get; set; }
        public DPOALL DPOALL { get; set; }
        public DPOMX DPOMX { get; set; }
        public DPXAD DPXAD { get; set; }
        public DPXALL DPXALL { get; set; }
        public DPXMX DPXMX { get; set; }
        public EKYRTRU7 EKYRTRU7 { get; set; }
        public HYM12MRTNB HYM12MRTNB { get; set; }
        public S7OBSRT S7OBSRT { get; set; }
        public S7OPLRT S7OPLRT { get; set; }
        public S7OSTRT S7OSTRT { get; set; }
        public S7QBSRT S7QBSRT { get; set; }
        public S7QPLRT S7QPLRT { get; set; }
        public S7QSTRT S7QSTRT { get; set; }
        public S7TPLRT S7TPLRT { get; set; }
        public S7TSTRT S7TSTRT { get; set; }
        public S7TBSRT S7TBSRT { get; set; }
        public SUGNBR SUGNBR { get; set; }
        public SUNNBR SUNNBR { get; set; }
        public SURNBR SURNBR { get; set; }
        public U6NECRT U6NECRT { get; set; }
        public U6NFLRT U6NFLRT { get; set; }
        public U6NPRRT U6NPRRT { get; set; }
        public U6ZBSRT U6ZBSRT { get; set; }
        public UTHFLEXRT UTHFLEXRT { get; set; }
        public UTHLTRT UTHLTRT { get; set; }
        public UTHSTDRT UTHSTDRT { get; set; }
        public UTKFLEXRT UTKFLEXRT { get; set; }
        public UTKLTRT UTKLTRT { get; set; }
        public UTKSTDRT UTKSTDRT { get; set; }
        public DPPROMOALL DPPROMOALL { get; set; }
        public DPPAD DPPAD { get; set; }
        public DPPMX DPPMX { get; set; }
        public S7NBSRT S7NBSRT { get; set; }
        public S7NSTRT S7NSTRT { get; set; }
        public S7NPLRT S7NPLRT { get; set; }
        public _7RLCSLTOW _7RLCSLTOW { get; set; }
        public _7RUCSLTOW _7RUCSLTOW { get; set; }
    }

    public class _5NIBSOW
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

    public class _5NILTOW
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
        public Description1[] descriptions { get; set; }
    }

    public class Description1
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

    public class _5NISTOW
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
        public Description2[] descriptions { get; set; }
    }

    public class Description2
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

    public class DPOAD
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
        public Description3[] descriptions { get; set; }
    }

    public class Description3
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

    public class DPOALL
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
        public Description4[] descriptions { get; set; }
    }

    public class Description4
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

    public class DPOMX
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
        public Description5[] descriptions { get; set; }
    }

    public class Description5
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

    public class DPXAD
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
        public Description6[] descriptions { get; set; }
    }

    public class Description6
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

    public class DPXALL
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
        public Description7[] descriptions { get; set; }
    }

    public class Description7
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

    public class DPXMX
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
        public Description8[] descriptions { get; set; }
    }

    public class Description8
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

    public class EKYRTRU7
    {
        public string id { get; set; }
        public string airline_code { get; set; }
        public string tariff_code { get; set; }
        public object tariff_family_code { get; set; }
        public object tariff_family_name { get; set; }
        public string type { get; set; }
        public bool is_fixed { get; set; }
        public bool is_gds { get; set; }
        public object carry_on_measure { get; set; }
        public object carry_on_value { get; set; }
        public string baggage_measure { get; set; }
        public string baggage_value { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public bool is_baggage { get; set; }
        public object baggage_state { get; set; }
        public object[] descriptions { get; set; }
    }

    public class HYM12MRTNB
    {
        public string id { get; set; }
        public string airline_code { get; set; }
        public string tariff_code { get; set; }
        public object tariff_family_code { get; set; }
        public string tariff_family_name { get; set; }
        public string type { get; set; }
        public bool is_fixed { get; set; }
        public bool is_gds { get; set; }
        public object carry_on_measure { get; set; }
        public object carry_on_value { get; set; }
        public string baggage_measure { get; set; }
        public string baggage_value { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public bool is_baggage { get; set; }
        public string baggage_state { get; set; }
        public Description9[] descriptions { get; set; }
    }

    public class Description9
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

    public class S7OBSRT
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
        public Description10[] descriptions { get; set; }
    }

    public class Description10
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

    public class S7OPLRT
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
        public Description11[] descriptions { get; set; }
    }

    public class Description11
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

    public class S7OSTRT
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
        public Description12[] descriptions { get; set; }
    }

    public class Description12
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

    public class S7QBSRT
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
        public Description13[] descriptions { get; set; }
    }

    public class Description13
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

    public class S7QPLRT
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
        public Description14[] descriptions { get; set; }
    }

    public class Description14
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

    public class S7QSTRT
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
        public Description15[] descriptions { get; set; }
    }

    public class Description15
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

    public class S7TPLRT
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
        public Description16[] descriptions { get; set; }
    }

    public class Description16
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

    public class S7TSTRT
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
        public Description17[] descriptions { get; set; }
    }

    public class Description17
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

    public class S7TBSRT
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
        public Description18[] descriptions { get; set; }
    }

    public class Description18
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

    public class SUGNBR
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
        public Description19[] descriptions { get; set; }
    }

    public class Description19
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

    public class SUNNBR
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
        public Description20[] descriptions { get; set; }
    }

    public class Description20
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

    public class SURNBR
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
        public Description21[] descriptions { get; set; }
    }

    public class Description21
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

    public class U6NECRT
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
        public Description22[] descriptions { get; set; }
    }

    public class Description22
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

    public class U6NFLRT
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
        public Description23[] descriptions { get; set; }
    }

    public class Description23
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

    public class U6NPRRT
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
        public Description24[] descriptions { get; set; }
    }

    public class Description24
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

    public class U6ZBSRT
    {
        public string id { get; set; }
        public string airline_code { get; set; }
        public string tariff_code { get; set; }
        public string tariff_family_code { get; set; }
        public string tariff_family_name { get; set; }
        public string type { get; set; }
        public bool is_fixed { get; set; }
        public bool is_gds { get; set; }
        public object carry_on_measure { get; set; }
        public object carry_on_value { get; set; }
        public string baggage_measure { get; set; }
        public string baggage_value { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public bool is_baggage { get; set; }
        public string baggage_state { get; set; }
        public Description25[] descriptions { get; set; }
    }

    public class Description25
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

    public class UTHFLEXRT
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
        public Description26[] descriptions { get; set; }
    }

    public class Description26
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

    public class UTHLTRT
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
        public Description27[] descriptions { get; set; }
    }

    public class Description27
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

    public class UTHSTDRT
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
        public Description28[] descriptions { get; set; }
    }

    public class Description28
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

    public class UTKFLEXRT
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
        public Description29[] descriptions { get; set; }
    }

    public class Description29
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

    public class UTKLTRT
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
        public Description30[] descriptions { get; set; }
    }

    public class Description30
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

    public class UTKSTDRT
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
        public Description31[] descriptions { get; set; }
    }

    public class Description31
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

    public class DPPROMOALL
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
        public Description32[] descriptions { get; set; }
    }

    public class Description32
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

    public class DPPAD
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
        public Description33[] descriptions { get; set; }
    }

    public class Description33
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

    public class DPPMX
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
        public Description34[] descriptions { get; set; }
    }

    public class Description34
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

    public class S7NBSRT
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
        public Description35[] descriptions { get; set; }
    }

    public class Description35
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

    public class S7NSTRT
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
        public Description36[] descriptions { get; set; }
    }

    public class Description36
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

    public class S7NPLRT
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
        public Description37[] descriptions { get; set; }
    }

    public class Description37
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

    public class _7RLCSLTOW
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
        public Description38[] descriptions { get; set; }
    }

    public class Description38
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

    public class _7RUCSLTOW
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
        public Description39[] descriptions { get; set; }
    }

    public class Description39
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
        public SU SU { get; set; }
        public S7 S7 { get; set; }
        public UT UT { get; set; }
        public U6 U6 { get; set; }
        public _5N _5N { get; set; }
        public _7R _7R { get; set; }
        public DP DP { get; set; }
        public EK EK { get; set; }
        public HY HY { get; set; }
    }

    public class SU
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
        public Name[] names { get; set; }
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

    public class S7
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
        public Name1[] names { get; set; }
    }

    public class Name1
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

    public class UT
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
        public Name2[] names { get; set; }
    }

    public class Name2
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

    public class U6
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
        public Name3[] names { get; set; }
    }

    public class Name3
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

    public class _5N
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
        public Name4[] names { get; set; }
    }

    public class Name4
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

    public class _7R
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
        public Name5[] names { get; set; }
    }

    public class Name5
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

    public class DP
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
        public Name6[] names { get; set; }
    }

    public class Name6
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

    public class EK
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
        public Name7[] names { get; set; }
    }

    public class Name7
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

    public class HY
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
        public Name8[] names { get; set; }
    }

    public class Name8
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
        public TAS TAS { get; set; }
        public DME DME { get; set; }
        public VKO VKO { get; set; }
        public LED LED { get; set; }
        public SVO SVO { get; set; }
        public DXB DXB { get; set; }
    }

    public class TAS
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
        public Name11[] names { get; set; }
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
        public Name10[] names { get; set; }
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
        public Name9[] names { get; set; }
    }

    public class Name9
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

    public class Name10
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

    public class Name11
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

    public class DME
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
        public Name14[] names { get; set; }
        public City1 city { get; set; }
    }

    public class City1
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
        public Name13[] names { get; set; }
        public Country1 country { get; set; }
    }

    public class Country1
    {
        public int id { get; set; }
        public string code { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public int order { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public Name12[] names { get; set; }
    }

    public class Name12
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

    public class Name13
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

    public class Name14
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

    public class VKO
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
        public Name17[] names { get; set; }
        public City2 city { get; set; }
    }

    public class City2
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
        public Name16[] names { get; set; }
        public Country2 country { get; set; }
    }

    public class Country2
    {
        public int id { get; set; }
        public string code { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public int order { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public Name15[] names { get; set; }
    }

    public class Name15
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

    public class Name16
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

    public class Name17
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

    public class LED
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
        public Name20[] names { get; set; }
        public City3 city { get; set; }
    }

    public class City3
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
        public Name19[] names { get; set; }
        public Country3 country { get; set; }
    }

    public class Country3
    {
        public int id { get; set; }
        public string code { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public int order { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public Name18[] names { get; set; }
    }

    public class Name18
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

    public class Name19
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

    public class Name20
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

    public class SVO
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
        public Name23[] names { get; set; }
        public City4 city { get; set; }
    }

    public class City4
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
        public Name22[] names { get; set; }
        public Country4 country { get; set; }
    }

    public class Country4
    {
        public int id { get; set; }
        public string code { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public int order { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public Name21[] names { get; set; }
    }

    public class Name21
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

    public class Name22
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

    public class Name23
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

    public class DXB
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
        public Name26[] names { get; set; }
        public City5 city { get; set; }
    }

    public class City5
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
        public Name25[] names { get; set; }
        public Country5 country { get; set; }
    }

    public class Country5
    {
        public int id { get; set; }
        public string code { get; set; }
        public bool is_active { get; set; }
        public bool is_fixed { get; set; }
        public int order { get; set; }
        public object created_at { get; set; }
        public object updated_at { get; set; }
        public string name { get; set; }
        public Name24[] names { get; set; }
    }

    public class Name24
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

    public class Name25
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

    public class Name26
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
        public SU9 SU9 { get; set; }
        public _789 _789 { get; set; }
        public _77W _77W { get; set; }
        public _763 _763 { get; set; }
        public _73H _73H { get; set; }
        public _738 _738 { get; set; }
        public _737 _737 { get; set; }
        public _388 _388 { get; set; }
        public _32N _32N { get; set; }
        public _32B _32B { get; set; }
        public _32A _32A { get; set; }
        public _321 _321 { get; set; }
        public _320 _320 { get; set; }
        public _319 _319 { get; set; }
        public _32Q _32Q { get; set; }
    }

    public class SU9
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

    public class _789
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

    public class _77W
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

    public class _763
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

    public class _73H
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

    public class _738
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

    public class _737
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

    public class _388
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

    public class _32N
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

    public class _32B
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

    public class _32A
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

    public class _321
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

    public class _320
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

    public class _319
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

    public class _32Q
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

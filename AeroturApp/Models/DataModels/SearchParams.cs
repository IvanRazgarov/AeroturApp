using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroturApp.Models.DataModels
{

    public class SearchParams
    {
        public string locale { get; set; } = "RU";
        public string instance { get; set; } = "aerotur.aero.dev";
        public int adults { get; set; } = 1;
        public int children { get; set; } = 0;
        public int infants { get; set; } = 0;
        public int infants_seat { get; set; } = 0;
        public string flight_class { get; set; } = "Economy";
        public string from { get; set; } = "LED";
        public string fromType { get; set; } = "city";
        public string to { get; set; } = "OSS";
        public string toType { get; set; } = "city";
        public string date1 { get; set; } = DateTime.Now.ToString("yyyy'-'mm'-'dd");
        public string date2 { get; set; } = null;
        public int asGrouped { get; set; } = 0;
    }
}

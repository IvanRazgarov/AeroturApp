using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroturApp.Models.DataModels
{

    public class SearchParams
    {
        public string locale { get; set; }
        public string instance { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
        public int infants { get; set; }
        public int infants_seat { get; set; }
        public string flight_class { get; set; }
        public string from { get; set; }
        public string fromType { get; set; }
        public string to { get; set; }
        public string toType { get; set; }
        public string date1 { get; set; }
        public string date2 { get; set; }
        public int asGrouped { get; set; }
    }

}

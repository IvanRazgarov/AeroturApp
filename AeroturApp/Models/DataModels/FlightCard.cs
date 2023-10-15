using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroturApp.Models.DataModels
{
    internal class FlightCard : Item
    {
        public string Company { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Transit { get; set; }
        public string Date { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public bool Luggage { get; set; }
        public bool HHLuggage { get; set; }
        public bool Rebook_return { get; set; }
        public int RUBCost { get; set; }
        public string Pricing {  get; set; }

    }
}

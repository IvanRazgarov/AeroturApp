using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroturApp.Models.DataModels;
public class Rootobject
{
    public Dictionary<string,string> name_translations { get; set; }
    public Dictionary<string,string> cases { get; set; }
    public string country_code { get; set; }
    public string code { get; set; }
    public string time_zone { get; set; }
    public string name { get; set; }
    public Dictionary<string,float> coordinates { get; set; }
}
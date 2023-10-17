using AeroturApp.Models.DataModels;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace AeroturApp.Services
{
    class WebAPIClients
    {
        //http://pics.avs.io/высота/ширина/ИАТА код.png для логотипов (для иос @2x)
        static HttpClient client = new HttpClient();

        static async Task<AirportCard> GetAirportAsync(string path)
        {
            AirportCard product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                JsonDocument JSONresponse = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
                product = new AirportCard();

                
            }
            return product;
        }

    }
}

using AeroturApp.Models.DataModels;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace AeroturApp.Services
{
    internal class WebAPIClients
    {
        //http://pics.avs.io/высота/ширина/ИАТА код.png для логотипов (для иос @2x)
        private readonly HttpClient client;

        private static string _flagsUrl = "";
        private static string _airportsUrl = "";
        private static string _aeroturApiUrl = "https://api.aerotur.aero/";
        // Добавить получения CSRF токена из первого гет запроса и логин в сессию.
        public WebAPIClients() 
        { 
            client = new HttpClient();
            client.BaseAddress = new Uri(_aeroturApiUrl);

        }
        public async Task<SearchParams> GetSearchResult(SearchParams parameters)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet) return null;

            return await client.GetFromJsonAsync<SearchParams>($"flights/");
        }
    }
}

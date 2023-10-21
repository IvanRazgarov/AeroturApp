using AeroturApp.Models.DataModels;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AeroturApp.Services
{
    internal class WebAPIClient
    {
        //http://pics.avs.io/высота/ширина/ИАТА код.png для логотипов (для иос @2x)
        private readonly HttpClient _client;
        private static HttpClientHandler _handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            UseCookies = true,
            CookieContainer = cookieContainer
        };
        private static CookieContainer cookieContainer = new CookieContainer();
        private const string AEROTUR_API_URL = "https://api.aerotur.aero/";

        public WebAPIClient() 
        {
            _client = new HttpClient(_handler);
            _client.BaseAddress = new Uri(AEROTUR_API_URL);
        }

        //private async PrepareConectionToAPI()
        //{

        //}

        /// <summary>
        /// Проходим через все страницы, получая токены csrf
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        private string GetCsrfTokenFromHtml(string html)
        {
            string pattern = """<meta name="csrf-token" content=".*">""";
            string node = Regex.Match(html, pattern).Value;
            node = node.Replace(" ","");
            node = node.Replace("\"", " ");
            node = node.Substring(1,node.Length-2);
            var parts = node.Split(' ');
            return parts[parts.Length-1];
        }
    }
}

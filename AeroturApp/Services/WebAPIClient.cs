using AeroturApp.Models.DataModels;
using System.Net;
using System.Net.Http.Json;
using System.Text.RegularExpressions;

namespace AeroturApp.Services
{
    internal class WebAPIClient
    {
        //http://pics.avs.io/высота/ширина/ИАТА код.png для логотипов (для иос @2x)
        private readonly HttpClient _client;
        private static CookieContainer cookieContainer = new CookieContainer();
        private HttpRequestMessage sessionRequest;
        private static HttpClientHandler _handler = new HttpClientHandler
        {
            AllowAutoRedirect = true,
            UseCookies = true,
            CookieContainer = cookieContainer
        };
        private string csrf;
        private const string AEROTUR_API_URL = "https://api.aerotur.aero/";

        public WebAPIClient() 
        {
            _client = new HttpClient(_handler, false);
            _client.BaseAddress = new Uri(AEROTUR_API_URL);
        }
        /// <summary>
        /// Проходит по страницам, получая csrf токены. Возвращает Request message, готовый для ввода данных поиска.
        /// </summary>
        /// <returns></returns>
        private async Task<HttpRequestMessage> StartSession()
        {
            _client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Mobile Safari/537.36");
            _client.DefaultRequestHeaders.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            _client.DefaultRequestHeaders.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            _client.DefaultRequestHeaders.Add("cache-control", "max-age=0");
            _client.DefaultRequestHeaders.Add("content-type", "application/x-www-form-urlencoded");
            _client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Opera GX\";v=\"102\"");
            _client.DefaultRequestHeaders.Add("sec-fetch-dest", "document");
            _client.DefaultRequestHeaders.Add("sec-fetch-mode", "navigate");
            _client.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
            _client.DefaultRequestHeaders.Add("sec-fetch-user", "?1");
            _client.DefaultRequestHeaders.Add("upgrade-insecure-requests", "1");
            using (HttpResponseMessage response1 = await _client.GetAsync(AEROTUR_API_URL + "login")) 
            {
                if (response1.IsSuccessStatusCode)
                {
                    string csrf = GetCsrfFromHtml(response1.Content.ToString());
                    if (csrf == null) return null;
                } 
            }
            using (var content = new StringContent($"_token={csrf}&email=vancat220%40gmail.com&password=VannaTallin2023")) 
            {
                using (HttpResponseMessage response2 = await _client.PostAsync(AEROTUR_API_URL + "login", content))
                {
                    if(response2.StatusCode == HttpStatusCode.Found)
                    {
                        using( HttpResponseMessage response3 = await _client.GetAsync(AEROTUR_API_URL + "home"))
                        {
                            if( response3.IsSuccessStatusCode)
                            {
                                csrf = GetCsrfFromHtml(response3.Content.ToString());
                                if (csrf == null) return null;
                            }
                        }
                    }
                }
            }
            _client.DefaultRequestHeaders.Remove("content-type");
            _client.DefaultRequestHeaders.Remove("accept");
            using (var request = new HttpRequestMessage(HttpMethod.Post, AEROTUR_API_URL+"home"))
            {
                request.Headers.Add("x-csrf-token", csrf);
                request.Headers.Add("accept", "application/json, text/plain, */*");
                request.Headers.Add("content-type", "application/json");
                return request;
            }
        }
        /// <summary>
        /// Принимает объект типа SearchParams и возвращает результаты поиска по этим параметрам
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public async Task<SearchReturn> SearchFlight(SearchParams parameters)
        {
            var request = await StartSession();
            var payload = JsonContent.Create(parameters);
            request.Content = payload;
            var response = await _client.SendAsync(request);
            var res = await response.Content.ReadFromJsonAsync<SearchReturn>();
            return res;
        }

        /// <summary>
        /// получает токен csrf из текста html
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        private string GetCsrfFromHtml(string html)
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

using AeroturApp.Models.DataModels;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.RegularExpressions;
#if ANDROID
using Xamarin.Android.Net;
#endif
namespace AeroturApp.Services
{
    public class WebAPIClient
    {
        private HttpClient httpClient;
        //private HttpRequestMessage? mainReqMessage;
        private static CookieContainer cookieContainer = new CookieContainer();
#if ANDROID
        private AndroidMessageHandler httpMessageHandler = new AndroidMessageHandler()
        {
            AllowAutoRedirect = true,
            UseCookies = true,
            CookieContainer = cookieContainer
        };
#else
        private HttpClientHandler httpMessageHandler = new HttpClientHandler()
        {
            AllowAutoRedirect = true,
            UseCookies = true,
            CookieContainer = cookieContainer
        };
#endif

        private const string AEROTUR_API_URL = "https://api-dev.aerotur.aero/api/";
        private const string AVIASALES_API_URL = "https://api.travelpayouts.com";

        public WebAPIClient()
        {
            httpClient = new HttpClient(httpMessageHandler, false)
            {
                //BaseAddress = new Uri(AEROTUR_API_URL)
            };
        }

        /// <summary>
        /// Пармаметры поиска, кроме date2 не должны быть пустыми. Возвращает объект результатов.
        /// </summary>
        /// <param name="creterias"></param>
        /// <returns></returns>
        public async Task<SearchReturn> SearchForFlights(SearchParams creterias)
        {
            /*var searchParams = new SearchParams()
            {
                locale = "RU",
                instance = "aerotur.aero.dev",
                adults = 1,
                children = 0,
                infants = 0,
                infants_seat = 0,
                flight_class = "Economy",
                from = "LED",
                fromType = "city",
                to = "OSS",
                toType = "city",
                date1 = "2023-11-04",
                date2 = null,
                asGrouped = 0
            };*/

            var mainReqMessage = new HttpRequestMessage(HttpMethod.Post, AEROTUR_API_URL+"flights");

            /*mainReqMessage.Headers.Add("User-Agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Mobile Safari/537.36");
            mainReqMessage.Headers.Add("accept", "application/json, text/plain, /*");
            mainReqMessage.Headers.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            mainReqMessage.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Opera GX\";v=\"102\"");
            mainReqMessage.Headers.Add("sec-ch-ua-mobile", "?1");
            mainReqMessage.Headers.Add("sec-ch-ua-platform", "\"Android\"");
            mainReqMessage.Headers.Add("sec-fetch-dest", "empty");
            mainReqMessage.Headers.Add("sec-fetch-mode", "cors");
            mainReqMessage.Headers.Add("sec-fetch-site", "same-origin");
            mainReqMessage.Headers.Add("x-requested-with", "XMLHttpRequest");*/

            /*if (creterias.date2 != null) 
            {
                var dat = DateTime.Parse(creterias.date2);
                if (dat <= DateTime.Now) creterias.date2 = null;
            }*/

            mainReqMessage.Content = JsonContent.Create(creterias);            

            var searchRes = await httpClient.SendAsync(mainReqMessage);
            if (!searchRes.IsSuccessStatusCode)
            {
                return new SearchReturn();
                //throw new Exception("Status code: "+searchRes.StatusCode+' '+searchRes.Content.ReadAsStringAsync().Result);
            }
            var resText = await searchRes.Content.ReadAsStringAsync();
            var res = new SearchReturn();
            try
            {
                res = JsonSerializer.Deserialize<SearchReturn>(resText);
            }
            catch (Exception ex)
            {
                mainReqMessage = new HttpRequestMessage(HttpMethod.Post, AEROTUR_API_URL + "flights");
                creterias.date1 = DateTime.Parse(creterias.date1).AddDays(1).ToString("yyyy'-'MM'-'dd");
                mainReqMessage.Content = JsonContent.Create(creterias);

                searchRes = await httpClient.SendAsync(mainReqMessage);
                resText = await searchRes.Content.ReadAsStringAsync();
                try
                {
                    res = JsonSerializer.Deserialize<SearchReturn>(resText);
                }
                catch (Exception ex2)
                {
                    res = new SearchReturn() { error_msg=resText+" No flights for date or tomorrow "+creterias};
                    //res.is_valid=false;
                    //res.error_msg =ex.Message+" , "+creterias.date1 +" , "+ resText;
                }
            }
            return res;           
        }

        public async Task<List<T>> GetIATAFromNet<T>()
        {
            var tail = "/data/ru/";
            var payload = new Dictionary<Type, Action>()
            {
                {typeof(IATA_Airport),()=>tail="airports.json?_gl=1*ajmg2k*_ga*MjEzNDk5MDg2MC4xNjk3NTY5NDQ0*_ga_1WLL0NEBEH*MTcwMDMzOTg3OC4xNC4wLjE3MDAzMzk4NzguNjAuMC4w" },
                {typeof(IATA_City), ()=>tail="cities.json?_gl=1*1o8h4ms*_ga*MjEzNDk5MDg2MC4xNjk3NTY5NDQ0*_ga_1WLL0NEBEH*MTcwMDMzOTg3OC4xNC4xLjE3MDAzNDA2MDIuNjAuMC4w" }
            };
            var request = new HttpRequestMessage(HttpMethod.Get, AVIASALES_API_URL+tail+payload);

            var searchRes = await httpClient.SendAsync(request);
            if (!searchRes.IsSuccessStatusCode)
            {
                return new List<T>();
                //throw new Exception("Status code: "+searchRes.StatusCode+' '+searchRes.Content.ReadAsStringAsync().Result);
            }
            var resText = await searchRes.Content.ReadAsStringAsync();
            var res = new List<T>();
            try
            {
                res = JsonSerializer.Deserialize<List<T>>(resText);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return res;

        }
    }
}

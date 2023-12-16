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
                res = JsonSerializer.Deserialize<SearchReturn>(resText);
            }
            catch
            {
                res = new SearchReturn() { error_msg = resText + " No flights for date or tomorrow " + creterias };
                //res.is_valid=false;
                //res.error_msg =ex.Message+" , "+creterias.date1 +" , "+ resText;
            }  
            
            if (res == null||res.variants == null) { throw new Exception("Invalid response. Flights missing?"); }

            foreach(var variant in res.variants)
            {
                foreach(var leg in variant.legs)
                {
                    foreach(var segment in leg.segments)
                    {
                        var i = 0;
                        if (i == leg.segments.Count - 1) segment.is_last=true;
                    }
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

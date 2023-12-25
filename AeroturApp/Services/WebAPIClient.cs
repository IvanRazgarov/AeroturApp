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
        private const string IATA_API_URL = "https://api.travelpayouts.com/data/ru/";

        public WebAPIClient()
        {
            httpClient = new HttpClient(httpMessageHandler, false)
            {
                //BaseAddress = new Uri(AEROTUR_API_URL)
            };
        }

        /// <summary>
        /// Пармаметры поиска в критериях, кроме date2, не должны быть пустыми. Возвращает объект результатов.
        /// </summary>
        /// <param name="creterias"></param>
        /// <returns></returns>
        public async ValueTask<SearchReturn> SearchForFlights(SearchParams creterias)
        {
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
        /// <summary>
        /// Возвращает лист элементов Т.
        /// Возможные элементы: IATA_Citi, IATA_Airport
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<List<T>> GetIATAFromNet<T>()
        {
            var payload = new Dictionary<Type, string>()
            {
                {typeof(IATA_Airport),"airports.json" },
                {typeof(IATA_Citi), "cities.json" }
            };
            var request = new HttpRequestMessage(HttpMethod.Get, IATA_API_URL+payload[typeof(T)]);

            var searchRes = await httpClient.SendAsync(request);
            if (!searchRes.IsSuccessStatusCode)
            {
                return new List<T>();
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
                return new List<T>();
            }
            return res;

        }
    }
}

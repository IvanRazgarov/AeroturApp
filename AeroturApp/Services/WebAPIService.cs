using AeroturApp.Models.DataModels;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
#if ANDROID
using Xamarin.Android.Net;
#endif
namespace AeroturApp.Services
{
    public class WebAPIService
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

        public WebAPIService()
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
            var mainReqMessage = new HttpRequestMessage(HttpMethod.Post, AEROTUR_API_URL + "flights");
            mainReqMessage.Content = JsonContent.Create(creterias);
            Debug.WriteLine("Send first flight request");
            var searchResponce = await httpClient.SendAsync(mainReqMessage);
            if (!searchResponce.IsSuccessStatusCode){return new SearchReturn() 
            { error_msg = "Request unsucksesfull with code: "+ searchResponce.StatusCode};}

            var responceContentString = await searchResponce.Content.ReadAsStringAsync();
            var result = new SearchReturn();
            try
            {
                result = JsonSerializer.Deserialize<SearchReturn>(responceContentString);
                PrepareDatastring(result);
            }
            catch (Exception ex1)
            {
                mainReqMessage = new HttpRequestMessage(HttpMethod.Post, AEROTUR_API_URL + "flights");
                creterias.date1 = DateTime.Parse(creterias.date1).AddDays(1).ToString("yyyy'-'MM'-'dd");
                mainReqMessage.Content = JsonContent.Create(creterias);
                Debug.WriteLine("Send second flight request");
                searchResponce = await httpClient.SendAsync(mainReqMessage);
                if (!searchResponce.IsSuccessStatusCode){return new SearchReturn()
                { error_msg = "Request unsucksesfull with code: " + searchResponce.StatusCode,
                  is_valid = false};}

                responceContentString = await searchResponce.Content.ReadAsStringAsync();
                try
                {
                    result = JsonSerializer.Deserialize<SearchReturn>(responceContentString);
                    PrepareDatastring(result);
                }
                catch(Exception ex2)
                {
                    return new SearchReturn() { error_msg = "Bad responce. Flights missing? Exception message: "+ex1.Message+" -> "+ex2.Message,
                    is_valid = false};
                }
            }

            return result;

            /*try
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
                res = JsonSerializer.Deserialize<SearchReturn>(resText);
                foreach(var v in res.variants)
                {
                    foreach(var l in v.legs)
                    {
                        res.segments.AddRange(l.segments);
                    }
                }
            */
            /*foreach(var variant in res.variants)
            {
                foreach(var leg in variant.legs)
                {
                    foreach(var segment in leg.segments)
                    {
                        segment.variant_header.flight_id = variant.flight_id;
                        segment.variant_header.flight_direction_type = variant.flight_direction_type;
                        segment.variant_header.is_direct_flight = variant.is_direct_flight;
                        segment.variant_header.ident = variant.ident;
                        segment.variant_header.flight_type = variant.flight_type;
                        segment.variant_header.booking_url = variant.booking_url;
                        segment.variant_header.seats = variant.seats;
                        segment.variant_header.expected_ticket_count = variant.expected_ticket_count;
                        segment.variant_header.supplier_id = variant.supplier_id;
                        segment.variant_header.supplier_name = variant.supplier_name;
                        segment.variant_header.price = variant.price;
                        segment.variant_header.currency = variant.currency;
                    }
                }
            }*/
            /*
            }
            catch
            {
                res = new SearchReturn() { error_msg = resText + " No flights for date or tomorrow " + creterias };
            }  
            
            if (res == null||res.variants == null) { throw new Exception("Invalid response. Flights missing?"); }

            try { }
            catch (Exception ex)
            {
                mainReqMessage = new HttpRequestMessage(HttpMethod.Post, AEROTUR_API_URL + "flights");
                creterias.date1 = DateTime.Parse(creterias.date1).AddDays(1).ToString("yyyy'-'MM'-'dd");
                mainReqMessage.Content = JsonContent.Create(creterias);

                searchRes = await httpClient.SendAsync(mainReqMessage);
                resText = await searchRes.Content.ReadAsStringAsync();
                res = JsonSerializer.Deserialize<SearchReturn>(resText);

                foreach (var v in res.variants)
                {
                    foreach (var l in v.legs)
                    {
                        res.segments.AddRange(l.segments);
                    }
                }
            */
            /*
                foreach (var variant in res.variants)
                {
                    foreach (var leg in variant.legs)
                    {
                        foreach (var segment in leg.segments)
                        {
                            segment.variant_header.flight_id = variant.flight_id;
                            segment.variant_header.flight_direction_type = variant.flight_direction_type;
                            segment.variant_header.is_direct_flight = variant.is_direct_flight;
                            segment.variant_header.ident = variant.ident;
                            segment.variant_header.flight_type = variant.flight_type;
                            segment.variant_header.booking_url = variant.booking_url;
                            segment.variant_header.seats = variant.seats;
                            segment.variant_header.expected_ticket_count = variant.expected_ticket_count;
                            segment.variant_header.supplier_id = variant.supplier_id;
                            segment.variant_header.supplier_name = variant.supplier_name;
                            segment.variant_header.price = variant.price;
                            segment.variant_header.currency = variant.currency;
                        }
                    }
                }
            }*/
//            return res;
        }

        private static void PrepareDatastring(SearchReturn result)
        {
            var images = "";
            foreach (var v in result.variants)
            {
                foreach (var l in v.legs)
                {
                    foreach (var s in l.segments)
                    {
                        s.parent_data += v.booking_url + ",";//0
                        s.parent_data += v.baggage.is_baggage + ",";//1
                        //s.parent_data += "False" + ",";//1
                        s.parent_data += v.carry_on.is_baggage + ",";//2
                        //s.parent_data += "True" + ",";//2
                        s.parent_data += v.price + ",";//3
                        s.parent_data += v.currency + ",";//4
                        s.parent_data += IataCodesService.GetAirportName(l.segments.First().departure_airport) + ",";//5
                        s.parent_data += l.segments.First().ddt +",";//6
                        s.parent_data += IataCodesService.GetAirportName(l.segments.Last().arrival_airport) + ",";//7
                        s.parent_data += l.segments.Last().adt + ",";//8
                        s.parent_data += (l.segments.Last().adt - l.segments.First().ddt)+",";//9
                        s.parent_data += (l.segments.Count <= 1) ? "Без пересадок" : $"Пересадки: {l.segments.Count}"+",";//10
                        //images += result.airlines[s.operating_company].logo_url+"*";
                    }
                    //foreach(var s in l.segments) { s.parent_data += images; }//11
                    result.segments.AddRange(l.segments);
                }
            }
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

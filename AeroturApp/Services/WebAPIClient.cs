using AeroturApp.Models.DataModels;
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
        private HttpClient? httpClient;
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

        public WebAPIClient()
        {
            CreateSession();
        }

        /// <summary>
        /// Совершает первые три запроса, необходимые для авторизации и получения куки. Создаёт RequestMessage для дельнейшего использования.
        /// </summary>
        public void CreateSession()
        {
            httpClient = new HttpClient(httpMessageHandler, false)
            {
                BaseAddress = new Uri(AEROTUR_API_URL)
            };

            
            //var firstReqMessage = new HttpRequestMessage(HttpMethod.Get, "login");

            //firstReqMessage.Headers.Add("User-Agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Mobile Safari/537.36");
            //firstReqMessage.Headers.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            //firstReqMessage.Headers.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            //firstReqMessage.Headers.Add("cache-control", "max-age=0");
            //firstReqMessage.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Opera GX\";v=\"102\"");
            //firstReqMessage.Headers.Add("sec-fetch-dest", "document");
            //firstReqMessage.Headers.Add("sec-fetch-mode", "navigate");
            //firstReqMessage.Headers.Add("sec-fetch-site", "same-origin");
            //firstReqMessage.Headers.Add("sec-fetch-user", "?1");
            //firstReqMessage.Headers.Add("upgrade-insecure-requests", "1");

            ////Console.WriteLine(firstReqMessage.Method.ToString());
            ////Console.WriteLine(httpClient.BaseAddress.ToString());
            ////Console.WriteLine(firstReqMessage.ToString());

            //var res1 = httpClient.SendAsync(firstReqMessage).Result;

            //string resText1 = res1.Content.ReadAsStringAsync().Result;
            //firstReqMessage.Dispose();

            ////Console.WriteLine(GetCsrfFromHtml(resText));

            //string csrf1 = GetCsrfFromHtml(resText1);
            //Console.WriteLine("captured: " + csrf1);

            //var secondReqMessage = new HttpRequestMessage(HttpMethod.Post, $"login?_token={csrf1}&email=vancat220%40gmail.com&password=VannaTallin2023");

            //secondReqMessage.Headers.Add("User-Agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Mobile Safari/537.36");
            //secondReqMessage.Headers.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            //secondReqMessage.Headers.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            //secondReqMessage.Headers.Add("cache-control", "max-age=0");
            //secondReqMessage.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Opera GX\";v=\"102\"");
            //secondReqMessage.Headers.Add("sec-fetch-dest", "document");
            //secondReqMessage.Headers.Add("sec-fetch-mode", "navigate");
            //secondReqMessage.Headers.Add("sec-fetch-site", "same-origin");
            //secondReqMessage.Headers.Add("sec-fetch-user", "?1");
            //secondReqMessage.Headers.Add("upgrade-insecure-requests", "1");

            ////secondReqMessage.Content = new StringContent($"_token={csrf1}&email=vancat220%40gmail.com&password=VannaTallin2023");

            ////Console.WriteLine(httpClient.BaseAddress.ToString());
            ////Console.WriteLine(secondReqMessage.ToString());

            //var res2 = httpClient.SendAsync(secondReqMessage).Result;
            ////Console.WriteLine(res2.ToString());

            //string resText2 = res2.Content.ReadAsStringAsync().Result;
            //secondReqMessage.Dispose();

            //string csrf2 = GetCsrfFromHtml(resText2);
            //Console.WriteLine("captured: " + csrf2);

            //var thirdReqMessage = new HttpRequestMessage(HttpMethod.Get, "home");

            //thirdReqMessage.Headers.Add("User-Agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Mobile Safari/537.36");
            //thirdReqMessage.Headers.Add("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            //thirdReqMessage.Headers.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            //thirdReqMessage.Headers.Add("cache-control", "max-age=0");
            //thirdReqMessage.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Opera GX\";v=\"102\"");
            //thirdReqMessage.Headers.Add("sec-fetch-dest", "document");
            //thirdReqMessage.Headers.Add("sec-fetch-mode", "navigate");
            //thirdReqMessage.Headers.Add("sec-fetch-site", "same-origin");
            //thirdReqMessage.Headers.Add("sec-fetch-user", "?1");
            //thirdReqMessage.Headers.Add("upgrade-insecure-requests", "1");

            //var res3 = httpClient.SendAsync(thirdReqMessage).Result;

            //string resText3 = res3.Content.ReadAsStringAsync().Result;
            //secondReqMessage.Dispose();

            //string mainCsrf = GetCsrfFromHtml(resText3);
            //Console.WriteLine("captured: " + mainCsrf);

            //mainReqMessage = new HttpRequestMessage(HttpMethod.Post, "flights");

            //mainReqMessage.Headers.Add("User-Agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Mobile Safari/537.36");
            //mainReqMessage.Headers.Add("accept", "application/json, text/plain, */*");
            //mainReqMessage.Headers.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            //mainReqMessage.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Opera GX\";v=\"102\"");
            //mainReqMessage.Headers.Add("sec-ch-ua-mobile", "?1");
            //mainReqMessage.Headers.Add("sec-ch-ua-platform", "\"Android\"");
            //mainReqMessage.Headers.Add("sec-fetch-dest", "empty");
            //mainReqMessage.Headers.Add("sec-fetch-mode", "cors");
            //mainReqMessage.Headers.Add("sec-fetch-site", "same-origin");
            //mainReqMessage.Headers.Add("x-csrf-token", mainCsrf);
            //mainReqMessage.Headers.Add("x-requested-with", "XMLHttpRequest");

            //SearchParams creterias = new()
            //{
            //    locale = "RU",
            //    instance = "aerotur.aero.dev",
            //    adults = 1,
            //    children = 0,
            //    infants = 0,
            //    infants_seat = 0,
            //    flight_class = "Economy",
            //    from = "MOW",
            //    fromType = "city",
            //    to = "LED",
            //    toType = "city",
            //    date1 = "2023-10-30",
            //    date2 = null,
            //    asGrouped = 0
            //};
            //mainReqMessage.Content = JsonContent.Create(creterias);

            //Console.WriteLine(mainReqMessage.Content.ReadAsStringAsync().Result);
            //var searchRes = httpClient.Send(mainReqMessage);

            //Console.WriteLine(searchRes);
            //searchRes.EnsureSuccessStatusCode();
            //var resText = searchRes.Content.ReadAsStringAsync().Result;
            //var res = JsonSerializer.Deserialize<SearchReturn>(resText);

            //Console.WriteLine(resText);
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

            var mainReqMessage = new HttpRequestMessage(HttpMethod.Post, "flights");

            mainReqMessage.Headers.Add("User-Agent", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Mobile Safari/537.36");
            mainReqMessage.Headers.Add("accept", "application/json, text/plain, */*");
            mainReqMessage.Headers.Add("accept-language", "ru-RU,ru;q=0.9,en-US;q=0.8,en;q=0.7");
            mainReqMessage.Headers.Add("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Opera GX\";v=\"102\"");
            mainReqMessage.Headers.Add("sec-ch-ua-mobile", "?1");
            mainReqMessage.Headers.Add("sec-ch-ua-platform", "\"Android\"");
            mainReqMessage.Headers.Add("sec-fetch-dest", "empty");
            mainReqMessage.Headers.Add("sec-fetch-mode", "cors");
            mainReqMessage.Headers.Add("sec-fetch-site", "same-origin");
            mainReqMessage.Headers.Add("x-requested-with", "XMLHttpRequest");

            mainReqMessage.Content = JsonContent.Create(creterias);

            var searchRes = await httpClient.SendAsync(mainReqMessage);
            if (!searchRes.IsSuccessStatusCode)
            {
                return new SearchReturn();
                //throw new Exception("Status code: "+searchRes.StatusCode+' '+searchRes.Content.ReadAsStringAsync().Result);
            }
            var resText = await searchRes.Content.ReadAsStringAsync();
            var res = JsonSerializer.Deserialize<SearchReturn>(resText);

            return res;
        }

        /// <summary>
        /// Получает код csrf из текста ответа.
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        /*private string GetCsrfFromHtml(string html)
        {
            string pattern = """<meta name="csrf-token" content=".*">""";
            string node = Regex.Match(html, pattern).Value;
            node = node.Replace(" ", "");
            node = node.Replace("\"", " ");
            node = node[1..^1];
            var parts = node.Split(' ');

            return parts[3];
        }*/

    }
}

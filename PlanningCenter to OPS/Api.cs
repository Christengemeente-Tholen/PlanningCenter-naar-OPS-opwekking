using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace PlanningCenter_to_OPS
{
    internal class Api
    {
        private static string GetRequest(Config config, string request)
        {
            HttpClient webClient = new();
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(config.app_id + ":" + config.secret));
            webClient.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials);
            HttpResponseMessage httpResponse = webClient.GetAsync(request).Result;
            if (httpResponse.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                throw new NotImplementedException(httpResponse.StatusCode.ToString());
            return httpResponse.Content.ReadAsStringAsync().Result;
        }

        public static Structs.ServicesOrg GetOrg(Config config)
        {
            string responseContent = GetRequest(config, "https://api.planningcenteronline.com/services/v2");
            Console.WriteLine(responseContent);
            if (responseContent != null)
                return JsonConvert.DeserializeObject<Structs.ServicesOrg>(responseContent);
            return null;
        }
        
        public static Structs.ServiceType GetServiceType(Config config)
        {
            string responseContent = GetRequest(config, "https://api.planningcenteronline.com/services/v2/service_types");
            return JsonConvert.DeserializeObject<Structs.ServiceType>(responseContent);
        }

        public static Structs.ServicePlans GetServicePlans(Config config, string service_type, string filter_date = "future") // no_dates | future
        {
            string url = String.Format(
                "https://api.planningcenteronline.com/services/v2/service_types/{0}/plans?order=sort_date&filter={1}&include=plan_times",
                service_type,
                filter_date
            );
            string responseContent = GetRequest(config, url);
            return JsonConvert.DeserializeObject<Structs.ServicePlans>(responseContent);
        }

        public static Structs.SongList GetSongList(Config config, string service_url)
        {
            string responseContent = GetRequest(config, String.Format("{0}/items", service_url));
            return JsonConvert.DeserializeObject<Structs.SongList>(responseContent);
        }

        public static Structs.Lyrics GetLyrics(Config config, string song_url)
        {
            string responseContent = GetRequest(config, String.Format("{0}/arrangement", song_url));
            return JsonConvert.DeserializeObject<Structs.Lyrics>(responseContent);
        }
    }
}

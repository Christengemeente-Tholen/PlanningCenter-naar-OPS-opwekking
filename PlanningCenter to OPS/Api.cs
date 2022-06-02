using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace PlanningCenter_to_OPS
{
    internal class Api
    {
        private static string GetRequest(Config config, string request)
        {
            WebClient webClient = new WebClient();
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(config.app_id + ":" + config.secret));
            webClient.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;
            return webClient.DownloadString(new Uri(request));
        }

        public static Structs.ServicesOrg GetOrg(Config config)
        {
            string data = GetRequest(config, "https://api.planningcenteronline.com/services/v2");
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Structs.ServicesOrg>(data);
        }
        
        public static Structs.ServiceType GetServiceType(Config config)
        {
            string data = GetRequest(config, "https://api.planningcenteronline.com/services/v2/service_types");
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Structs.ServiceType>(data);
        }

        public static Structs.ServicePlans GetServicePlans(Config config, string service_type)
        {
            DateTime dt = DateTime.Now;
            string url = String.Format(
                "https://api.planningcenteronline.com/services/v2/service_types/{0}/plans?order=sort_date&filter=after&after={1}&include=plan_times",
                service_type,
                dt.ToString("yyyy-MM-dd")
            );
            string data = GetRequest(config, url);
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Structs.ServicePlans>(data);
        }

        public static Structs.SongList GetSongList(Config config, string service_url)
        {
            string data = GetRequest(config, String.Format("{0}/items", service_url));
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Structs.SongList>(data);
        }

        public static Structs.Lyrics GetLyrics(Config config, string song_url)
        {
            string data = GetRequest(config, String.Format("{0}/arrangement", song_url));
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Structs.Lyrics>(data);
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;

namespace BukasisWinFormsApp
{
    public partial class bukasis
    {
        private static readonly string baseUrl = "http://85.100.124.69:5555/";

        public static string get(string oturumKodu,string link)
        {
             using (var client = new HttpClient())
            {
                var endpoint = new Uri(baseUrl+link);
                client.DefaultRequestHeaders.Add("oturum",oturumKodu);
                var result=client.GetAsync(endpoint).Result.Content.ReadAsStringAsync().Result;
                return result;
            }
        }

        public static string post(string code, string sifre ,string link)
        {
            using (var client = new HttpClient())
            {
                string sifr = md5.sifrele(sifre);
                var endpoint = new Uri(baseUrl+link);
                var newPost = new Login()
                {
                    kullaniciKodu = code,
                    kullaniciSifre = sifr.ToLower(),
                    bilgisayarAdi = Dns.GetHostName()

                };
                var newPostJson = JsonConvert.SerializeObject(newPost);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                var result=client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
                return result;
            }
          
        }
        public static string postObject(JObject nots, string pkBasvuru, string oturumKodu)
        {
            using (var client = new HttpClient())
            {               
                var endpoint = new Uri(baseUrl+ "api/yetkili/HastaTakip/belirliHastaKlinikNotEkle/" + pkBasvuru);
                var newPostJson = JsonConvert.SerializeObject(nots);
                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");
                client.DefaultRequestHeaders.Add("oturum", oturumKodu);
                var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
                return result;
            }

        }

        public static string jsonResponse(string jsonStr)
        {
            JToken jToken = JToken.Parse(jsonStr);

            return jToken.ToString(Formatting.Indented);
        }

        public string put()
        {
            return null;
        }

        public JsonArray delete()
        {
            return null;
        }
    }
}
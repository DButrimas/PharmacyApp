using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PharmacyApp
{
    public class Data
    {
        public string post_code { get; set; }
        public string address { get; set; }
        public string street { get; set; }
        public string number { get; set; }
        public string city { get; set; }
        public string municipality { get; set; }
        public string post { get; set; }
        public string mailbox { get; set; }
    }

    public class RootObject
    {
        public string status { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
        public int message_code { get; set; }
        public int total { get; set; }
        public List<Data> data { get; set; }
    }


    public static class PostItAPI
    {

        static HttpClient client = new HttpClient();

        static string ApiUrl = ConfigurationManager.AppSettings["ApiUrl"];
        static string ApiKey = ConfigurationManager.AppSettings["ApiKey"];


        private static string BuildUrl(string address)
        {
            string[] temp = address.Split(new string[] { "g.", "al.", "pr.", "," }, StringSplitOptions.None);
            string city = temp[2];
            string street = temp[0];
            string house = temp[1];

            string url = $"{ApiUrl}?term={street}+{house},+{city}&key={ApiKey}";

            return url;
        }

        public static async Task<string> GetPostCode(string address)
        {
            string jsonString = null;

            string url = BuildUrl(address);

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                jsonString = await response.Content.ReadAsStringAsync();
            }

            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(jsonString);
           
            return rootObject.data[0].post_code;
            }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SNCFDatabase
{
    public static class SncfRequestTrainInfos
    {
        
        public static List<MyStationContent> getTrainLineId(string cityParam)
        {
            string URL = "https://api.sncf.com/v1/coverage/sncf/pt_objects";
            string token_auth = "df899ea3-f923-4134-8566-16187a6aad4e";
            string qParam = cityParam;
            string urlParameters = "?q=" + qParam + "&type%5B%5D=line&count=200&key=" + token_auth;

            qParam = cityParam;
            return parseResp(makeRequest(URL + urlParameters));
        }


        public static string makeRequest(string urlRequestSncf)
        {
            var client = new RestClient(urlRequestSncf);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("accept", "application/json");
            return client.Execute(request).Content;
        }

        public static List<MyStationContent> parseResp(string response)
        {
            List<Object> listRes = new List<Object>();

            var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
            var result = dict.Where(x => x.Key == "pt_objects").Select(s => s.Value).ToArray();

            JArray data = (JArray)result[0];
            List<MyStationContent> list_station = new List<MyStationContent>();

            foreach (JToken o in data)
            {
                string Line = o["name"].Value<string>();
                string id = o["id"].Value<string>();
                
                list_station.Add(new MyStationContent(Line.ToString(), id.ToString()));
            }

            return list_station;
        }

    }

    public class MyStationContent
    {
        public string name { get; set; }
        public string id { get; set; }


        public MyStationContent(string n, string i)
        {
            id = i;
            name = n;
        }
    }

}

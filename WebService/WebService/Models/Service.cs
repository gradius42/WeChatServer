using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebService
{
    public class Service : IService
    {
        private string databaseURL = "http://localhost:21918/";
        private int test { get; set; }

        public String GetMessage(String name)
        {
            return "Ello world form " + name + " !";
        }

        public int GetResultOfAddition(int val1, int val2)
        {
            return val1 + val2;
        }

        public void SetTest(int val1)
        {
            test = val1;
        }

        public int GetTest()
        {
            return test;
        }

        public Task<HttpResponseMessage> GetCities()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(databaseURL);

            return client.GetAsync("api/Cities");
        }
    }
}

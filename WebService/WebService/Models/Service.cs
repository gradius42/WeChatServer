using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using SncfRequest;

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

        public List<StationContentData> GetTrainStation(string name)
        {
            List<MyStationContent> stationContent = SncfRequest.SncfRequestTrainInfos.getTrainLineId(name);

            List<StationContentData> res = new List<StationContentData>();

            foreach(MyStationContent s in stationContent)
            {
                StationContentData data = new StationContentData();
                data.Id = s.id;
                data.Name = s.name;
                res.Add(data);
            }

            return res;
        }
    }
}

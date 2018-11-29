using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebService
{
    interface IService
    {
        string GetMessage(string name);
        int GetResultOfAddition(int val1, int val2);
        void SetTest(int val);
        int GetTest();
        List<StationContentData> GetTrainStation(string name);
    }

    [DataContract]
    public class StationContentData
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Id { get; set; }
    }
}

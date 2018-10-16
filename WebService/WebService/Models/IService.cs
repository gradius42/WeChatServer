using System.Net.Http;
using System.Threading.Tasks;

namespace WebService
{
    interface IService
    {
        string GetMessage(string name);
        int GetResultOfAddition(int val1, int val2);
        void SetTest(int val);
        int GetTest();

        Task<HttpResponseMessage> GetCities();
    }
}

using System;
using System.Collections.Generic;
using WebService;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            WebService.Service service = new WebService.Service();

            Console.WriteLine("GetTrainStation(strasbourg)");
            Console.ReadKey();

            List<StationContentData> res = service.GetTrainStation("strasbourg");

            foreach(StationContentData s in res)
            {
                Console.WriteLine("ID : " + s.Id + " ; Name : " + s.Name);
            }


            Console.ReadKey();
        }
    }
}

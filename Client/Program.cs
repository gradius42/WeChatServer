using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            string val;
            ServiceReference1.ServiceClient test = new ServiceReference1.ServiceClient();
            //MonService.ServiceClient test = new MonService.ServiceClient();
            Console.WriteLine(test.GetMessage("Niko"));
            
            Console.WriteLine(test.GetResultOfAddition(1, 2));
            val = Console.ReadLine();
            test.SetTest(int.Parse(val));
            Console.WriteLine(test.GetTest());
            
            Console.ReadKey();
        }
    }
}

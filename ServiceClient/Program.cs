using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            1.ServiceClient test = new ServiceClient.ServiceReference1.ServiceClient();
            Console.WriteLine(test.GetMessage("Niko"));
          
        }
    }
}

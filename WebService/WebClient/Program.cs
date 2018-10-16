using System;

namespace WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string val;
            WebService.Service test = new WebService.Service();

            Console.WriteLine(test.GetMessage("Niko"));

            Console.WriteLine(test.GetResultOfAddition(1, 2));
            val = Console.ReadLine();
            test.SetTest(int.Parse(val));
            Console.WriteLine(test.GetTest());

            Console.ReadKey();

            Console.WriteLine(test.GetCities());
            Console.ReadKey();
        }
    }
}

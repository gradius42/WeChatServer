using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFServices
{
    public class Service : IService
    { 
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

    }
}

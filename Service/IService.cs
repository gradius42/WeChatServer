using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyWCFServices
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        String GetMessage(String name);
        [OperationContract]
        int GetResultOfAddition(int val1, int val2);
        [OperationContract]
        void SetTest(int val);
        [OperationContract]
        int GetTest();
    }
}

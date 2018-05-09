using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFServiceOuiChat;
using System.ServiceModel.Description;

namespace WebServiceLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("https://localhost:8000/WeChat");
            
            ServiceHost selfHost = new ServiceHost(typeof(WeChatService)); ;

            try
            {
                selfHost.AddServiceEndpoint(typeof(IService), new WSHttpBinding(), "WCFServiceWeChat");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();

                Console.WriteLine("WeChat web service open");



            }
            catch (CommunicationException ex)
            {
                Console.WriteLine(ex.Message);
                selfHost.Abort();
            }

        }
    }
}

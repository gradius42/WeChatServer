using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFServiceOuiChat;
using System.ServiceModel.Description;
using System.Net;
using System.Net.Sockets;

namespace WebServiceLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            // open port : netsh http add urlacl url=http://+:9997/ user=%USERDOMAIN%\%USERNAME%
            Uri baseAdress = new Uri("http://localhost:9997/OuiChatWCF");
            
            ServiceHost selfHost = new ServiceHost(typeof(OuiChatService)); ;

            try
            {
                selfHost.AddServiceEndpoint(typeof(IService), new WSHttpBinding(), baseAdress.OriginalString);

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = false;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();

                Console.WriteLine("OuiChat web service open");
                Console.WriteLine("Marchine IP : " + GetLocalIPAddress());
                Console.WriteLine("Server URL : " + baseAdress.OriginalString.Replace("localhost", GetLocalIPAddress()));


            }
            catch (CommunicationException ex)
            {
                Console.WriteLine(ex.Message);
                selfHost.Abort();
            }

            string endstr = "";
            while( (endstr = Console.ReadLine()) != "close");
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}

using System;
using System.ServiceModel;
using WCFCommon;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] _)
        {
            try
            {
                CreateServer();

                Console.WriteLine("Server OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static void CreateServer()
        {
            var serviceHost = new ServiceHost(typeof(Communication));

            var binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

            serviceHost.AddServiceEndpoint(typeof(ICommunication), binding, WCFConstants.ADDRESS);
            serviceHost.Open();
        }
    }
}

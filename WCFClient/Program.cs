using System;
using System.ServiceModel;
using WCFCommon;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] _)
        {
            try
            {
                var channel = CreateClient();

                Console.WriteLine("Client OK");

                channel.SendPeople(new Device()
                {
                    Name = "Entrance"
                });

                Console.WriteLine("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static ICommunication CreateClient()
        {
            var binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);

            var endpointAddress = new EndpointAddress(WCFConstants.ADDRESS);

            var communicationCallback = new CommunicationCallback();

            var duplexChannel = new DuplexChannelFactory<ICommunication>(communicationCallback, binding, endpointAddress);

            return duplexChannel.CreateChannel();
        }
    }
}

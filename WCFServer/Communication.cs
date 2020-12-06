using System;
using System.Linq;
using System.ServiceModel;
using System.Threading;
using WCFCommon;

namespace WCFServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Communication : ICommunication
    {
        public void SendPeople(Device device)
        {
            var callback = OperationContext.Current.GetCallbackChannel<ICommunicationCallback>();

            Console.WriteLine($"Communicating with device {device.Name}");

            foreach (var person in Enumerable.Range(1, 10))
            {
                Thread.Sleep(1000);

                callback.ReportProgress($"Sending people {person}");
            }

            Console.WriteLine("Finished");
        }
    }
}

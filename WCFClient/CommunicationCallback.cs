using System;
using WCFCommon;

namespace WCFClient
{
    public class CommunicationCallback : ICommunicationCallback
    {
        public void ReportProgress(string message)
        {
            Console.WriteLine(message);
        }
    }
}

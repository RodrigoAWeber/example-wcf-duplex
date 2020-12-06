using System.ServiceModel;

namespace WCFCommon
{
    public interface ICommunicationCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReportProgress(string message);
    }
}

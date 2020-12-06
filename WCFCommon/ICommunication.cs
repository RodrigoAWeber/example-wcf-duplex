using System.ServiceModel;

namespace WCFCommon
{
    [ServiceContract(CallbackContract = typeof(ICommunicationCallback))]
    public interface ICommunication
    {
        [OperationContract]
        void SendPeople(Device dadosEquipamento);
    }
}

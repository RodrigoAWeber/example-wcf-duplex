using System.Runtime.Serialization;

namespace WCFCommon
{
    [DataContract]
    public class Device
    {
        [DataMember]
        public string Name { get; set; }
    }
}

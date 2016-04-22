using System.Runtime.Serialization;

namespace ProcessusKillerService
{
    [DataContract]
    public class ProcessusModel
    {
        [DataMember]
        public string StringValue { get; set; }
    }
}
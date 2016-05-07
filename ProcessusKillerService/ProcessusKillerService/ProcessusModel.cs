using System.Runtime.Serialization;

namespace KillerService.Wcf
{
    [DataContract]
    public class ProcessusModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Id { get; set; }
    }
}
using System.Runtime.Serialization;

namespace ProcessusKillerService
{
    [DataContract]
    public class ProcessusModel
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string MainWindowTitle { get; set; }

        [DataMember]
        public int Id { get; set; }
    }
}
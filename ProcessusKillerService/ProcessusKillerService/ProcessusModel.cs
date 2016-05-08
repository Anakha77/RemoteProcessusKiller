using System.Runtime.Serialization;

namespace KillerService.Wcf
{
    [DataContract]
    public class ProcessusModel
    {
        private readonly Model.ProcessusModel _processusModel;

        public ProcessusModel(Model.ProcessusModel processusModel)
        {
            _processusModel = processusModel;
        }

        [DataMember]
        public string Name => _processusModel.Name;

        [DataMember]
        public int Id => _processusModel.Id;
    }
}
using System.ServiceModel;
using log4net;

namespace ProcessusKillerService
{
    [ServiceContract]
    public interface IKillerService
    {
        ILog Log { get; set; }

        [OperationContract]
        ProcessusModel[] GetProcessus();

        [OperationContract]
        ProcessusModel[] GetProcessusByName(string name);

        [OperationContract]
        bool StopProcessus(string name);
    }
}

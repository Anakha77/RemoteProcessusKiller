using System.ServiceModel;
using log4net;

namespace ProcessusKillerService.Interfaces
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
        bool StopProcessusByName(string name);

        [OperationContract]
        bool StopProcessusById(int id);
    }
}

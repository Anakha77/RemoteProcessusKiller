using KillerService.Model;
using log4net;

namespace KillerService.ServiceLibrary
{
    public interface IKillerService
    {
        ILog Log { get; set; }

        /// <summary>
        /// Get all processus running on the computer
        /// </summary>
        /// <returns></returns>
        ProcessusModel[] GetProcessus();

        /// <summary>
        /// Return all named processus running on the computer
        /// </summary>
        /// <param name="name">Name of the processus</param>
        /// <returns>Array of ProcessusModel corresponding to all the processus with de name "name"</returns>
        ProcessusModel[] GetProcessusByName(string name);

        /// <summary>
        /// Retunr the processus running with the specified Id
        /// </summary>
        /// <param name="id">Identifier of the processus</param>
        /// <returns>ProcessusModel corresponding to the specific processus</returns>
        ProcessusModel GetProcessusById(int id);

        /// <summary>
        /// Try to stop all the named processus
        /// </summary>
        /// <param name="name">Processus name to stop</param>
        /// <returns>True if the stop processus command succeed</returns>
        bool StopProcessusByName(string name);

        /// <summary>
        /// Try to stop one processus identified by his Id
        /// </summary>
        /// <param name="id">Identifier of the processus to kill</param>
        /// <returns>True if the stop processus command succeed</returns>
        bool StopProcessusById(int id);
    }
}
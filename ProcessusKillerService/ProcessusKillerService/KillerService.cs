using System;
using System.Linq;
using log4net;

namespace ProcessusKillerService
{
    public class KillerService : IKillerService
    {
        public ILog Log { get; set; }

        /// <summary>
        /// Get all processus running on the computer
        /// </summary>
        /// <returns></returns>
        public ProcessusModel[] GetProcessus()
        {
            return System.Diagnostics.Process.GetProcesses()
                .Where(p => p.ProcessName != "WindowsKillerService" && !string.IsNullOrEmpty(p.MainWindowTitle))
                .Select(p => new ProcessusModel
                {
                    Name = p.ProcessName,
                    MainWindowTitle = p.MainWindowTitle,
                    Id = p.Id})
                .OrderBy(p => p.MainWindowTitle).ToArray();
        }

        /// <summary>
        /// Return all named processus running on the computer
        /// </summary>
        /// <param name="name">Name of the processus</param>
        /// <returns>Array of ProcessusModel corresponding to all the processus with de name "name"</returns>
        public ProcessusModel[] GetProcessusByName(string name)
        {
            return GetProcessus().Where(p => p.Name.Equals(name)).ToArray();
        }

        /// <summary>
        /// Retunr the processus running with the specified Id
        /// </summary>
        /// <param name="id">Identifier of the processus</param>
        /// <returns>ProcessusModel corresponding to the specific processus</returns>
        public ProcessusModel GetProcessusById(int id)
        {
            return GetProcessus().FirstOrDefault(p => p.Id == id);
        }

        /// <summary>
        /// Try to stop all the named processus
        /// </summary>
        /// <param name="name">Processus name to stop</param>
        /// <returns>True if the stop processus command succeed</returns>
        public bool StopProcessusByName(string name)
        {
            try
            {
                System.Diagnostics.Process.GetProcessesByName(name).ToList().ForEach(p => p.Kill());
                return true;
            }
            catch (Exception ex)
            {
                Log?.Error(ex.Message, ex);
                return false;
            }
        }

        /// <summary>
        /// Try to stop one processus identified by his Id
        /// </summary>
        /// <param name="id">Identifier of the processus to kill</param>
        /// <returns>True if the stop processus command succeed</returns>
        public bool StopProcessusById(int id)
        {
            try
            {
                System.Diagnostics.Process.GetProcessById(id).Kill();
                return true;
            }
            catch (Exception ex)
            {
                Log?.Error(ex.Message, ex);
                return false;
            }
        }
    }
}

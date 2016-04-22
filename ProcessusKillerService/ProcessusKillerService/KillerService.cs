using System;
using System.Linq;
using log4net;

namespace ProcessusKillerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class KillerService : IKillerService
    {
        public ILog Log { get; set; }

        /// <summary>
        /// Get all processus running on the computer
        /// </summary>
        /// <returns></returns>
        public ProcessusModel[] GetProcessus()
        {
            return System.Diagnostics.Process.GetProcesses().Select(p => new ProcessusModel {StringValue = p.ProcessName}).ToArray();
        }

        /// <summary>
        /// Return all named processus running on the computer
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ProcessusModel[] GetProcessusByName(string name)
        {
            return GetProcessus().Where(p => p.StringValue.Equals(name)).ToArray();
        }

        /// <summary>
        /// Try to stop all the named processus
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool StopProcessus(string name)
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
    }
}

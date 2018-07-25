using System;
using System.Linq;
using log4net;
using ProcessusKillerService.Interfaces;

namespace ProcessusKillerService
{
    public class KillerService : IKillerService
    {
        public ILog Log { get; set; }

        private readonly IProcessService _processService;

        public KillerService()
        {
            var implName = System.Configuration.ConfigurationManager.AppSettings["ProcessServiceImpl"];
            var implType = Type.GetType(implName);
            var impl = implType.GetConstructor(Type.EmptyTypes).Invoke(null) as IProcessService;
            _processService = impl ?? throw new Exception($"Erreur lors du chargement de l'implementation {implName}");
        }



        /// <summary>
        /// Get all processus running on the computer
        /// </summary>
        /// <returns></returns>
        public ProcessusModel[] GetProcessus()
        {
            return _processService.GetProcessus().ToArray();
        }

        /// <summary>
        /// Return all named processus running on the computer
        /// </summary>
        /// <param name="name">Name of the processus</param>
        /// <returns>Array of ProcessusModel corresponding to all the processus with de name "name"</returns>
        public ProcessusModel[] GetProcessusByName(string name)
        {
            return _processService.GetProcessus().Where(p => p.Name.Equals(name)).ToArray();
        }

        /// <summary>
        /// Retunr the processus running with the specified Id
        /// </summary>
        /// <param name="id">Identifier of the processus</param>
        /// <returns>ProcessusModel corresponding to the specific processus</returns>
        public ProcessusModel GetProcessusById(int id)
        {
            return _processService.GetProcessus().FirstOrDefault(p => p.Id == id);
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
                _processService.GetProcessus().Where(p => p.Name.Equals(name)).ToList().ForEach(p => _processService.KillProcessus(p.Id));
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
                _processService.KillProcessus(id);
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

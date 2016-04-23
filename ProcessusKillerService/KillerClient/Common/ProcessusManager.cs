using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerClient.KillerService;

namespace KillerClient.Common
{
    public static class ProcessusManager
    {
        public static async Task<List<Processus>> GetProcessusAsync()
        {
            return await Task.Run(() => GetProcessus());
        }

        public static List<Processus> GetProcessus()
        {
            var processus = GetProcessusModels();
            return new List<Processus>(processus.Select(p => new Processus { Name = p.Name, Id = p.Id }));
        }

        public static ProcessusModel[] GetProcessusModels()
        {
            return GetService().GetProcessus();
        }

        public static void StopProcessus(string processusName)
        {
            bool requestResult, requestResultSpecified;
            GetService().StopProcessusByName(processusName, out requestResult, out requestResultSpecified);
        }

        public static void StopProcessus(int processusId)
        {
            bool requestResult, requestResultSpecified;
            GetService().StopProcessusById(processusId, true, out requestResult, out requestResultSpecified);
        }

        private static KillerService.KillerService GetService()
        {
            var service = new KillerService.KillerService();
            var config = ConfigManager.LoadConfiguration();
            service.Url = $"http://{config["ServerAdress"]}:{config["ServerPort"]}/ProcessusKillerService/";
            return service;
        }
    }
}
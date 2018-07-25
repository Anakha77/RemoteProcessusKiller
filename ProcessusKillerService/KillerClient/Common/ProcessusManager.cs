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
            return new List<Processus>(processus.Select(p => new Processus
            {
                Name = p.Name,
                MainWindowTitle = p.MainWindowTitle,
                Id = p.Id }
            )).OrderBy(p => p.DisplayName).ToList();
        }

        public static ProcessusModel[] GetProcessusModels()
        {
            var service = GetService();
            var processus = service.GetProcessus();
            return processus;
        }

        public static void StopProcessus(string processusName)
        {
            GetService().StopProcessusByName(processusName, out bool requestResult, out bool requestResultSpecified);
        }

        public static void StopProcessus(int processusId)
        {
            GetService().StopProcessusById(processusId, true, out bool requestResult, out bool requestResultSpecified);
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
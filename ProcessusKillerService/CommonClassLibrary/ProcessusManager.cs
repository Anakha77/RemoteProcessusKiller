using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KillerClient.KillerService;

namespace KillerClient.Common
{
    public static class ProcessusManager
    {
        public static async Task<List<Processus>> GetProcessus()
        {
            var processus = await GetProcessusModelsAsync();
            return new List<Processus>(processus.Select(p => new Processus {Name = p.StringValue}));
        }

        public static async Task<ProcessusModel[]> GetProcessusModelsAsync()
        {
            var service = new KillerService.KillerService();
            return await Task.Run(() => service.GetProcessus());
        }
    }
}
using ServiceClientConsole.KillerServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = GetProcessus();

            process
                //.Where(p => p.MainWindowTitle != "").ToList()
                .OrderBy(p => p.Name).ToList()
                .ForEach(p =>
                {
                    string line = FormatLine(p);

                    Console.WriteLine(line);
                });

            Console.ReadLine();
        }

        private static string FormatLine(Processus p)
        {
            var line = $"PID : {p.Id}\t\t{p.Name}";
            if (!string.IsNullOrWhiteSpace(p.MainWindowTitle))
                line += $" ({p.MainWindowTitle})";
            return line;
        }

        public static async Task<List<Processus>> GetProcessusAsync()
        {
            var service = GetService();
            var process = await service.GetProcessusAsync();
            return GetProcessus(process);
        }

        public static List<Processus> GetProcessus()
        {
            var service = GetService();
            var process = service.GetProcessus();

            return GetProcessus(process);
        }

        private static List<Processus> GetProcessus(ProcessusModel[] process)
        {
            return process.Select(p => new Processus
            {
                Id = p.Id,
                MainWindowTitle = p.MainWindowTitle,
                Name = p.Name
            }).ToList();
        }

        public static void StopProcessus(string processusName)
        {
            GetService().StopProcessusByName(processusName);
        }

        public static void StopProcessus(int processusId)
        {
            GetService().StopProcessusById(processusId);
        }

        private static IKillerService GetService()
        {
            return new KillerServiceClient();
            //client.
            //var service = new KillerServiceReference.. ();
            //var config = ConfigManager.LoadConfiguration();
            //service.Url = $"http://{config["ServerAdress"]}:{config["ServerPort"]}/ProcessusKillerService/";
            //return service;
        }

    }
}

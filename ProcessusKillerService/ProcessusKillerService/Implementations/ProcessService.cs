using ProcessusKillerService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProcessusKillerService.Implementations
{
    public class ProcessService : IProcessService
    {
        public List<ProcessusModel> GetProcessus()
        {
            var process = new List<ProcessusModel>();

            foreach (var p in System.Diagnostics.Process.GetProcesses().Where(p => p.ProcessName != "WindowsKillerService"))
            {
                try
                {
                    process.Add(new ProcessusModel
                    {
                        Name = p.ProcessName,
                        MainWindowTitle = p.MainModule?.FileVersionInfo?.FileDescription,
                        Id = p.Id
                    });
                }
                catch (Exception ex)
                {
                    process.Add(new ProcessusModel
                    {
                        Name = p.ProcessName,
                        Id = p.Id
                    });
                }
            }

            return process;
        }

        public void KillProcessus(int PID)
        {
            System.Diagnostics.Process.GetProcessById(PID).Kill();
        }
    }
}

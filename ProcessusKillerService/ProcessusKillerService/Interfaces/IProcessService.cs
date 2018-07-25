using System.Collections.Generic;

namespace ProcessusKillerService.Interfaces
{
    public interface IProcessService
    {
        List<ProcessusModel> GetProcessus();
        void KillProcessus(int PID);
    }
}

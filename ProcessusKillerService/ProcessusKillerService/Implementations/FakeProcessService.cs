using ProcessusKillerService.Interfaces;
using System.Collections.Generic;

namespace ProcessusKillerService.Implementations
{
    public class FakeProcessService : IProcessService
    {
        public List<ProcessusModel> GetProcessus()
        {
            return new List<ProcessusModel>
            {
                new ProcessusModel
                {
                    Id = 0,
                    MainWindowTitle = "Test Windows Title",
                    Name = "Test Name"
                }
            };
        }

        public void KillProcessus(int PID)
        {
            // do nothing
        }
    }
}

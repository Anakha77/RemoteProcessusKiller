using System.Linq;
using System.Reflection;
using log4net;
using Ninject;

namespace KillerService.Wcf
{
    public class WcfKillerService : IKillerService
    {
        public ILog Log { get; set; }

        private readonly ServiceLibrary.IKillerService _killerService;

        public WcfKillerService()
        {
            using (var kernel = new StandardKernel())
            {
                kernel.Load(Assembly.GetExecutingAssembly());
                _killerService = kernel.Get<ServiceLibrary.IKillerService>();
            }
        }

        public ProcessusModel[] GetProcessus()
        {
            return _killerService.GetProcessus().Where(p => p.Name != "WindowsKillerService").Select(p => new ProcessusModel {Id = p.Id, Name = p.Name}).ToArray();
        }

        public ProcessusModel[] GetProcessusByName(string name)
        {
            return GetProcessus().Where(p => p.Name.Equals(name)).ToArray();
        }

        public bool StopProcessusByName(string name)
        {
            return _killerService.StopProcessusByName(name);
        }

        public bool StopProcessusById(int id)
        {
            return _killerService.StopProcessusById(id);
        }
    }
}

using System.ServiceModel;
using System.ServiceProcess;
using ProcessusKillerService;

namespace WindowsKillerService
{
    public partial class WindowsKillerServer : ServiceBase
    {
        public ServiceHost SvcHost;
         
        public WindowsKillerServer()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            SvcHost?.Close();
            SvcHost = new ServiceHost(typeof(KillerService));
            SvcHost.Open();
        }

        protected override void OnStop()
        {
            if (SvcHost == null) return;

            SvcHost.Close();
            SvcHost = null;
        }
    }
}

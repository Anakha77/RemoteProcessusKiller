using System.ServiceProcess;

namespace KillerService.ServiceHost
{
    public partial class WindowsKillerServer : ServiceBase
    {
        public System.ServiceModel.ServiceHost SvcHost;
         
        public WindowsKillerServer()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            SvcHost?.Close();
            SvcHost = new System.ServiceModel.ServiceHost(typeof(Wcf.WcfKillerService));
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

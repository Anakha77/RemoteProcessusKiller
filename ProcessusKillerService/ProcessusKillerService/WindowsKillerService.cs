using System.ServiceModel;
using System.ServiceProcess;

namespace ProcessusKillerService
{
    partial class WindowsKillerService : ServiceBase
    {
        public ServiceHost SvcHost;

        public WindowsKillerService()
        {
            InitializeComponent();
            ServiceName = "Processus Killer Service";
        }

        protected override void OnStart(string[] args)
        {
            SvcHost?.Close();

            // Create a ServiceHost for the CalculatorService type and 
            // provide the base address.
            SvcHost = new ServiceHost(typeof(KillerService));

            // Open the ServiceHostBase to create listeners and start
            // listening for messages.
            SvcHost.Open();
        }

        protected override void OnStop()
        {
            if (SvcHost == null) return;

            SvcHost.Close();
            SvcHost = null;
        }

        public static void Main()
        {
            Run(new WindowsKillerService());
        }

    }
}

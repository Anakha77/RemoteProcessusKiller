using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace ProcessusKillerService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public ProjectInstaller()
        {
            InitializeComponent();

            process = new ServiceProcessInstaller {Account = ServiceAccount.LocalSystem};
            service = new ServiceInstaller {ServiceName = "Processus Killer Service" };
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}

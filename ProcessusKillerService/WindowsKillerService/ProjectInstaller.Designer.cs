namespace KillerService.ServiceHost
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KillerServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.KillerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // KillerServiceProcessInstaller
            // 
            this.KillerServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.KillerServiceProcessInstaller.Password = null;
            this.KillerServiceProcessInstaller.Username = null;
            // 
            // KillerServiceInstaller
            // 
            this.KillerServiceInstaller.DisplayName = "Allow browsing processus and killing processus from the list";
            this.KillerServiceInstaller.ServiceName = "Windows Killer Service";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.KillerServiceProcessInstaller,
            this.KillerServiceInstaller});

        }

        #endregion
        public System.ServiceProcess.ServiceInstaller KillerServiceInstaller;
        public System.ServiceProcess.ServiceProcessInstaller KillerServiceProcessInstaller;
    }
}
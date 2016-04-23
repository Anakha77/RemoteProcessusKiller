﻿using System.ServiceProcess;

namespace WindowsKillerService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new WindowsKillerServer()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}

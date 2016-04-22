﻿using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProcessusKillerService;

namespace KillerServiceTestProject
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        public void Should_return_non_empty_array_of_process_When_calling_GetProcessus_method()
        {
            // Arrange
            var ks = new KillerService();

            // Act
            var processus = ks.GetProcessus();

            // Assert
            Assert.IsTrue(processus?.Length > 0);
        }

        [TestMethod]
        public void Should_return_non_empty_array_of_process_When_calling_GetProcessus_method_with_name()
        {
            // Arrange
            var ks = new KillerService();
            var process = Process.GetCurrentProcess();

            // Act
            var processus = ks.GetProcessusByName(process.ProcessName);

            // Assert
            Assert.IsTrue(processus?.Length > 0);
        }

        [TestMethod]
        public void Should_kill_process_When_calling_StopProcessus_with_name()
        {
            // Arrange
            var ks = new KillerService();
            Process.Start("Calc");
            Task.Delay(2000);

            // Act
            ks.StopProcessus("Calculator");
            Task.Delay(2000);

            // Assert
            Assert.IsTrue(Process.GetProcessesByName("Calculator").Length.Equals(0));
        }
    }
}

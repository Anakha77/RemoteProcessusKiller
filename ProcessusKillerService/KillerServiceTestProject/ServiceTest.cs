using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using KillerService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KillerService.TestProject
{
    [TestClass]
    public class ServiceTest
    {
        const string Json = "[{\"Id\":1,\"Name\":\"Processus1\"},{\"Id\":2,\"Name\":\"Processus2\"}]";

        [TestMethod]
        public void Should_return_non_empty_array_of_process_When_calling_GetProcessus_method()
        {
            // Arrange
            var ks = new ServiceLibrary.KillerService();

            // Act
            var processus = ks.GetProcessus();

            // Assert
            Assert.IsTrue(processus?.Length > 0);
        }

        [TestMethod]
        public void Should_return_non_empty_array_of_process_When_calling_GetProcessus_method_with_name()
        {
            // Arrange
            var ks = new ServiceLibrary.KillerService();
            var process = Process.GetCurrentProcess();

            // Act
            var processus = ks.GetProcessusByName(process.ProcessName);

            // Assert
            Assert.IsTrue(processus?.Length > 0);
        }

        [TestMethod]
        public void Should_kill_process_When_calling_StopProcessusByName()
        {
            // Arrange
            var ks = new ServiceLibrary.KillerService();
            Process.Start("Calc");
            Thread.Sleep(2000);

            // Act
            ks.StopProcessusByName("Calculator");
            Thread.Sleep(2000);

            // Assert
            Assert.IsTrue(Process.GetProcessesByName("Calculator").Length.Equals(0));
        }

        [TestMethod]
        public void Should_kill_process_When_calling_StopProcessusById()
        {
            // Arrange
            var ks = new ServiceLibrary.KillerService();
            Process.Start("Calc");
            Thread.Sleep(2000);
            var pCalc = Process.GetProcessesByName("Calculator").FirstOrDefault();

            // Act
            ks.StopProcessusById(pCalc.Id);
            Thread.Sleep(2000);

            // Assert
            Assert.IsNull(Process.GetProcesses().FirstOrDefault(p => p.Id == pCalc.Id));
        }

        [TestMethod]
        public void Should_return_serialized_json_When_serialize_array_of_processuses()
        {
            // Arrange
            var processuses = new[]
            {new ProcessusModel {Id = 1, Name = "Processus1"}, new ProcessusModel {Id = 2, Name = "Processus2"}};

            // Act
            var serialized = ServiceLibrary.JsonParser.Serialize(processuses);

            // Assert
            Assert.AreEqual(serialized, Json);
        }

        [TestMethod]
        public void Should_initialize_array_of_processus_When_deserialize_json_string()
        {
            // Assert
            var deserialized = new object();

            // Act
            ServiceLibrary.JsonParser.Deserialize(Json, out deserialized);
            var processuses = (ProcessusModel[])deserialized;

            // Assert
            Assert.AreEqual(processuses.Length, 2);
        }
    }
}

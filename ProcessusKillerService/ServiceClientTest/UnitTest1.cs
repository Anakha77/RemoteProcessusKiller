using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceClientTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var server = new ServiceReference1.KillerServiceClient();

            // Act
            var result = server.GetProcessus();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KillerClient.Common;

namespace ClientTest
{
    /// <summary>
    /// Summary description for ProcessusManagerTest
    /// </summary>
    [TestClass]
    public class ProcessusManagerTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Should_obtain_processus_list_When_calling_manager()
        {
            // Arrange

            // Act
            var getTask = ProcessusManager.GetProcessus();
            var processus = getTask.Result;

            // Assert
            Assert.IsTrue(processus?.Count > 0);
        }
    }
}

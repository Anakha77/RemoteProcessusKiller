using System;
using NUnit.Framework;


namespace KillerClientTestProject
{
    [TestFixture]
    public class TestsSample
    {

        [SetUp]
        public void Setup() { }


        [TearDown]
        public void Tear() { }

        [Test]
        public void Should_get_response_When_calling_webservice()
        {
            // Arrange
            var server = new KillerService.KillerService();

            // Act
            var result = server.GetProcessus();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
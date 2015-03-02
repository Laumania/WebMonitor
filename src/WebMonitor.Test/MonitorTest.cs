using WebMonitor.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebMonitor.Engine.Plugin;

namespace WebMonitor.Test
{
    
    
    /// <summary>
    ///This is a test class for MonitorTest and is intended
    ///to contain all MonitorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MonitorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Monitor Ping method
        ///</summary>
        [TestMethod()]
        public void Monitor_Ping_Should_Return_PingResult_With_Out_Error()
        {
            //Arrange
            MonitorManager manager = new MonitorManager();
            Monitor target = null;
            MonitorPingResult result = null;
            
            //Act
            manager.Initialize();
            target = manager.CreateMonitor("Test of valid url monitor", "http://laumania.net");
            result = target.Ping();

            //Assert
            Assert.IsNotNull(result);
            Assert.IsNull(result.Error);
            Assert.IsTrue(result.Succeeded);
        }

        /// <summary>
        ///A test for Monitor Ping method with invalid url
        ///</summary>
        [TestMethod()]
        public void Monitor_Ping_Should_Return_Error_On_Invalid_Url()
        {
            //Arrange
            MonitorManager manager = new MonitorManager();
            Monitor target = null;
            MonitorPingResult result = null;

            //Act
            manager.Initialize();
            target = manager.CreateMonitor("Test of invalid url monitor", "htassatp://lau@mania.net");
            result = target.Ping();

            //Assert
            Assert.IsNotNull(result.Error);
            Assert.IsFalse(result.Succeeded);
        }
    }
}

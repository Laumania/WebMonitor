using WebMonitor.Engine.Plugin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WebMonitor.Test.Plugins
{
    
    
    /// <summary>
    ///This is a test class for MonitorPluginManagerTest and is intended
    ///to contain all MonitorPluginManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MonitorPluginManagerTest
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
        ///A test for Initialize
        ///</summary>
        [TestMethod()]
        public void MonitorPluginManager_Initialize()
        {
            MonitorPluginManager target = new MonitorPluginManager();
            target.Initialize();
            Assert.IsTrue(true, "If this fails, we got an exception from the Initialization of the MonitorPluginManager");
        }

        /// <summary>
        ///A test for ComposePart
        ///</summary>
        [TestMethod()]
        public void MonitorPluginManager_Plugins_Are_NotNull()
        {
            //Arrange
            MonitorPluginManager target = new MonitorPluginManager();
            
            //Act
            target.Initialize();

            //Assert
            Assert.IsNotNull(target.Plugins);
        }
    }
}

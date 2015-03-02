using WebMonitor.Engine.DataStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WebMonitor.Engine;
using System.Collections.Generic;
using System.IO;

namespace WebMonitor.Test
{
    
    
    /// <summary>
    ///This is a test class for MonitorDataStoreTest and is intended
    ///to contain all MonitorDataStoreTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MonitorDataStoreTest
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
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void MonitorDataStore_Save_And_Load_Monitor_File()
        {
            //Arrange
            int monitorAmount = 5;
            
            //We make a temp file name, to be sure we are testing against the right
            //file and not one from a previous test
            string tempFilename = "Monitors_" + Guid.NewGuid() +".xml"; 
            List<Monitor> monitors = HelperMethods.GenerateMonitorList(monitorAmount);
            List<Monitor> loadedMonitors = null;

            //Act
            MonitorDataStore.Save(monitors, tempFilename);
            loadedMonitors = MonitorDataStore.Load(tempFilename);

            //Assert
            Assert.IsTrue(monitors.Count == loadedMonitors.Count);
            Assert.IsTrue(monitors[3].Id == loadedMonitors[3].Id);

            //Cleanup
            File.Delete(tempFilename);
        }
    }
}

using WebMonitor.Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;

namespace WebMonitor.Test
{
    
    
    /// <summary>
    ///This is a test class for MonitorManagerTest and is intended
    ///to contain all MonitorManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MonitorManagerTest
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
        ///A test for SaveMonitors
        ///</summary>
        [TestMethod()]
        public void MonitorManager_SaveMonitors_Should_Save_A_Real_File()
        {
            //Arrange
            MonitorManager target = new MonitorManager();
            target.Initialize();
            HelperMethods.FillMonitorList(target);

            //Act
            target.SaveMonitors();

            //Assert
            Assert.IsTrue(File.Exists("Monitors.xml"));
        }

        /// <summary>
        ///A test for CreateMonitor
        ///</summary>
        [TestMethod()]
        public void MonitorManager_CreateMonitor_Should_Get_An_Clean_Monitor_Back()
        {
            MonitorManager target = new MonitorManager();
            target.Initialize();
            Monitor actual;
            actual = target.CreateMonitor("Test name", "http://laumania.net");
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for LoadMonitors
        ///</summary>
        [TestMethod()]
        public void MonitorManager_LoadMonitors_Should_Have_A_List_Larger_Than_Zero()
        {
            //Arrange
            MonitorManager target = new MonitorManager();
            target.Initialize();
            HelperMethods.FillMonitorList(target);
            target.SaveMonitors();

            //Act
            target.LoadMonitors();

            //Assert
            Assert.IsNotNull(target.Monitors);
            Assert.IsTrue(target.Monitors[0].Plugins.Count > 0);
            Assert.IsTrue(target.Monitors.Length > 0);
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void MonitorManager_Add_Adds_One_Monitor_To_The_List()
        {
            //Arrange
            MonitorManager target = new MonitorManager();
            Monitor monitor = new Monitor();

            //Act
            target.Initialize();
            target.Add(monitor);

            //Assert
            Assert.IsTrue(target.Monitors.Length == 1);
            Assert.AreEqual(monitor, target.Monitors[0]);
        }

        /// <summary>
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void MonitorManager_CreateMonitor_Should_ComposeParts_So_Export_And_Imports_Are_Satisfied()
        {
            //Arrange
            MonitorManager target = new MonitorManager();
            Monitor monitor = null;

            //Act
            target.Initialize();
            monitor = target.CreateMonitor("ComposeParts_Test", "http://laumania");

            //Assert
            Assert.IsTrue(monitor.Plugins != null);
            Assert.IsTrue(monitor.Plugins.Count > 0);
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void MonitorManager_Save_And_Load_Monitors_And_Save_And_Load_PluginSettings()
        {
            //Arrange
            int monitorAmount = 5;

            //We make a temp file name, to be sure we are testing against the right
            //file and not one from a previous test
            MonitorManager manager = new MonitorManager();
            List<Monitor> monitors = HelperMethods.GenerateMonitorList(monitorAmount);
            monitors[0].Plugins[0].Enabled = true;

            //Act
            manager.Initialize();
            manager.AddMany(monitors);
            manager.SaveMonitors();
            manager.ClearMonitorList();
            manager.LoadMonitors();

            //Assert
            Assert.IsTrue(monitors[0].Plugins[0].Enabled == true);
            Assert.IsTrue(monitors[0].Plugins[1].Enabled == false);
        }

        /// <summary>
        ///A test for Load
        ///</summary>
        [TestMethod()]
        public void MonitorManager_PingMonitors_Should_Leave_Some_HistoryData()
        {
            //Arrange
            int monitorAmount = 5;
            MonitorManager manager = new MonitorManager();
            List<Monitor> monitors = HelperMethods.GenerateMonitorList(monitorAmount);

            //Act
            manager.Initialize();
            manager.AddMany(monitors);
            manager.SaveMonitors();
            manager.PingMonitors();

            //Assert
            Assert.IsTrue(File.Exists("Data/" +DateTime.Now.ToShortDateString() +".xml")); //Bad check, come up with something else!
        }
    }
}

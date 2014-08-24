using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RailsManager;


namespace unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRailsApp()
        {
            RailsApp a = new RailsApp(@"C:\Ruby193\bin\rails.bat", @"C:\projects\V");
            Assert.AreEqual(@"C:\projects\V", a.ToString());

            a.run("development", 3000);

            a.stop();
            // new RailsApp(@"c:\aaa");
        }
    }
}

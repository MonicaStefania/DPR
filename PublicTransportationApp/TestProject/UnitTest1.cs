using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PublicTransportationApp;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDelay()
        {
            Train t = new Train("London", "Paris", 12, 44, 2);
            int delay = 12;
            t.DelayTrain(t, delay);
            int result = t.Delay;
            Assert.AreEqual(result, delay);
            
        }
        [TestMethod]
        public void TestAddTrain()
        {
            Train t = new Train("Prague", "Amsterdam", 14, 55, 2);
            t.AddTrain(t);
            bool check = t.myTrains.Contains(t);
            Assert.AreEqual(check, true);
        }
        [TestMethod]
        public void TestRemoveTrain()
        {
            Train t = new Train("Prague", "Amsterdam", 14, 55, 2);
            t.RemoveTrain(t);
            bool check = t.myTrains.Contains(t);
            Assert.AreEqual(check, false);
        }

    }
}

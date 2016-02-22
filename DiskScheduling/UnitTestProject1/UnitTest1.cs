using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiskScheduling;
using System.Collections.Generic;


namespace DiskScheduleTesting
{
    [TestClass]
    public class DiskScheduleTesting
    {
        IDiskSchedule diskScheduling;
        
        [TestMethod]
        public void TestingSCAN()
        {
            int[] OSnumbers = new int[] { };
            diskScheduling = new SCAN();
            OSnumbers = diskScheduling.Schedule();
             int[] expectedNumber = OSnumbers;
             int[] testNumber = new int[] { 2, 3, 6, 10, 11, 12, 13,16, 24, 28, 45, 47, 48, 49, 50, 62, 100 };
            for (int i = 0; i < expectedNumber.Length; i++)
            {
                Assert.AreEqual(testNumber[i], expectedNumber[i]);
            }
           
        }
        [TestMethod]
        public void TestingFIFO()
        {
            int[] OSnumbers = new int[] { };
            diskScheduling = new FIFO();
            OSnumbers = diskScheduling.Schedule();
            int[] expectedNumber = OSnumbers;
            int[] testNumber = new int[] { 24, 45, 3, 49, 100, 6, 2, 13, 16, 11, 12, 47, 48, 28, 50, 10, 62 };
            
            for (int i = 0; i < expectedNumber.Length; i++)
            {
                Assert.AreEqual(testNumber[i], expectedNumber[i]);
            }

        }
       
    }
}

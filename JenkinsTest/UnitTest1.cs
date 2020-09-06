using System;
using Jenkins_Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program program = new Program();

            Assert.IsTrue(program.Test(78));
        }
    }
}

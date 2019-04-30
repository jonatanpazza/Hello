using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;

namespace HelloTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Equals("Hello World", Program.createMessage());   
        }
    }
}

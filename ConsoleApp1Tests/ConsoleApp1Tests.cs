using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ConsoleApp1Tests
    {
        [TestMethod()]
        public void testfuncTest()
        {
            Assert.AreEqual(ConsoleApp1.testfunc(), "hello");
        }
    }
}
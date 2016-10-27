using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
    [TestClass]
    public class ExamplesInMsTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Trace.WriteLine("Hello starting test");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("test 1");
            Assert.AreEqual(true, false);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Trace.WriteLine("test 2");
            Assert.AreEqual(true, false);
        }

        [TestCleanup]
        public void End()
        {
            Trace.Write("Bye bye, end test");
        }
    }
}

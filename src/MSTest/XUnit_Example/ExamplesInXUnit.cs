using System;
using Xunit;

namespace XUnit_Example
{
    public class ExamplesInXUnit : IDisposable
    {
        public ExamplesInXUnit()
        {
            // odpowiednik   [TestInitialize]
        }

        [Fact]
        public void XUnit_test()
        {
            Assert.Equal(true,true);
        }


        public void Dispose()
        {
            // odpowiednik   [TestCleanup]
        }
    }
}

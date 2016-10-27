using System;
using Xunit;

namespace XUnit_Example
{
    public class Class1 : IDisposable
    {
        public Class1()
        {
            
        }

        [Fact]
        public void XUnit_test()
        {
            Assert.Equal(true,true);
        }


        public void Dispose()
        {
           
        }
    }
}

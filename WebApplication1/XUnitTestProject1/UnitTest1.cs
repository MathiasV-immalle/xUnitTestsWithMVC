using System;
using Xunit;
using WebApplication1;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        // Put all your tests over here. Do not forget to add your main project to the dependencies of your xUnit project.

        [Fact]
        public void JoinShouldJoinTwoString()
        {
            Assert.Equal("tested", WebApplication1.Controllers.testcontroller.Join("test", "ed"));
        }
    }
}

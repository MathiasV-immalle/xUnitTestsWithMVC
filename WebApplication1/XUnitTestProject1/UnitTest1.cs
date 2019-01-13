using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        // Put all your tests over here. Do not forget to add your main project to the dependencies of your xUnit project.

        [Fact]
        public void JoinShouldJoinTwoString()
        {
            Assert.Equal("tested", WebApplication1.Controllers.testcontroller.JoinTwoWords("test", "ed"));
        }

        [Fact]
        public void ClashCountDNAPartsShouldCountDNAParts()
        {
            Assert.Equal("Amount A:7 Amount C:4 Amount G:6 Amount T:4.", WebApplication1.Controllers.testcontroller.ClashCountDNAParts("ATGCTTCAGAAAAGGTCAGCG"));
        }

        [Fact]
        public void a()
        {
            Assert.Equal("Borrowed: 13 coins.", WebApplication1.Controllers.testcontroller.BorrowMoney("3 17 4"));
        }
    }
}

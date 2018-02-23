namespace HotelCalifornia.Tests
{
    public class TestBase
    {
        [Fact]
        public void TestExampleToPass() 
        {
            Assert.Equal(1 == 1);
        }

        [Fact]
        public void TestExampleToFail() 
        {
            Assert.Equal(1 != 1);
        }
    }
}
using System.Collections.Generic;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverDriverFixture
    {
        private MarsRoverDriver _driver;
        public MarsRoverDriverFixture()
        {
            _driver = new MarsRoverDriver();
        }
        [Fact]
        public void Test_for_valid_output1()
        {
            var input = new List<string>() { "5 5", "1 2 N", "LMLMLMLMM" };
            string output = _driver.TakeInput(input);
            Assert.Equal("1 3 N", output);
        }

        [Fact]
        public void Test_for_valid_output2()
        {
            var input = new List<string>() { "5 5", "3 3 E", "MMRMMRMRRM" };
            string output = _driver.TakeInput(input);
            Assert.Equal("5 1 E", output);
        }
    }
}

using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverFixture
    {
        private Rover _rover;
        public RoverFixture()
        {
            _rover = new Rover(2, 3, 'E');
        }

        [Fact]
        public void Every_rover_has_its_position_test()
        {
            var expectedPostion = _rover.CurrentPosition;
            expectedPostion.Should().BeEquivalentTo<RoverPosition>(new RoverPosition(2, 3, Directions.East));
        }
    }
}

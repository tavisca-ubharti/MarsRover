using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class RoberCommandFixture
    {
        private RoverCommand  _command;
        public RoberCommandFixture()
        {
            Map.MaxXCoordinate = 5;
            Map.MaxYCoordinate = 5;
            _command = new RoverCommand();
        }

        [Fact]
        public void Given_series_of_instruction_should_return_valid_position_test()
        {
            var position = new RoverPosition(2, 3, Directions.North);
            var instructionList = new char []{ 'L', 'L', 'M' };
            foreach (var instruction in instructionList)
                position = _command.GetUpdatedPositionOnExecutingCommand(instruction, position);
            position.Should().BeEquivalentTo(new RoverPosition(2, 2, Directions.South));
        }

        [Fact]
        public void Given_series_of_instruction_should_return_valid_position_test2()
        {
            var position = new RoverPosition(2, 3, Directions.NorthEast);
            var instructionList = new char[] { 'L', 'L', 'M' ,'R'};
            foreach (var instruction in instructionList)
                position = _command.GetUpdatedPositionOnExecutingCommand(instruction, position);
            position.Should().BeEquivalentTo(new RoverPosition(1, 2, Directions.NorthWest));
        }
    }
}

using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoberFixture
    {
        private Rover _rover;
        private RoverCommand _roberCommand;
        public MarsRoberFixture()
        {
            Map.MaxXCoordinate = 5;
            Map.MaxYCoordinate = 5;
            _roberCommand = new RoverCommand();
        }

        [Fact]
        public void Given_series_of_instruction_should_return_updated_position_test()
        {
            _rover = new Rover(1, 2, 'N');
            string instruction = "LMLMLMLMM";
            var instructionList = instruction.ToCharArray();
            foreach (var command in instructionList)
                _rover.CurrentPosition = _roberCommand.GetUpdatedPositionOnExecutingCommand(command, _rover.CurrentPosition);
            _rover.CurrentPosition.Should().BeEquivalentTo<RoverPosition>(new RoverPosition(1, 3, Directions.North));
        }

        [Fact]
        public void Given_series_of_instruction_should_return_updated_position_test2()
        {
            _rover = new Rover(3, 3, 'E');
            string instruction = "MMRMMRMRRM";
            var instructionList = instruction.ToCharArray();
            foreach (var command in instructionList)
                _rover.CurrentPosition = _roberCommand.GetUpdatedPositionOnExecutingCommand(command, _rover.CurrentPosition);
            _rover.CurrentPosition.Should().BeEquivalentTo<RoverPosition>(new RoverPosition(5, 1, Directions.East));
        }
    }
}

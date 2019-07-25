using FluentAssertions;
using Xunit;

namespace MarsRover.Tests
{
    public class ActionFixture
    {
        private RoverAction _action;
        public ActionFixture()
        {
            _action = new RoverAction();
        }

        [Fact]
        public void Given_instruction_to_rotate_left_should_rotate_left_test()
        {
            var expectedPostion = _action.Rotate(new RoverPosition(2, 3, Directions.North),Instruction.Left);
            expectedPostion.Should().BeEquivalentTo<RoverPosition>(new RoverPosition(2, 3, Directions.West));
        }

        [Fact]
        public void Given_instruction_to_rotate_right_should_rotate_right_test()
        {
            var expectedPostion = _action.Rotate(new RoverPosition(2, 3, Directions.North), Instruction.Right);
            expectedPostion.Should().BeEquivalentTo<RoverPosition>(new RoverPosition(2, 3, Directions.East));
        }

        [Fact]
        public void Given_instruction_to_move_forward_should_move_test()
        {
            var expectedPostion = _action.MoveForward( new RoverPosition(2,3, Directions.North));
            expectedPostion.Should().BeEquivalentTo<RoverPosition>(new RoverPosition(2, 4, Directions.North));
        }

        [Fact]
        public void Given_instruction_to_move_forward_outside_map_should_not_move_test()
        {
            var expectedPostion = _action.MoveForward(new RoverPosition(0, 0, Directions.West));
            expectedPostion.Should().BeEquivalentTo<RoverPosition>(new RoverPosition(0, 0, Directions.West));
        }
    }
}

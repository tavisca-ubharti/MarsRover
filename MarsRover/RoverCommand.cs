namespace MarsRover
{
    public class RoverCommand
    {
        private RoverAction _action = new RoverAction();
        public RoverPosition GetUpdatedPositionOnExecutingCommand(char instruction,RoverPosition position)
        {
            if (Instruction.Move == (Instruction)instruction)
                return  _action.MoveForward(position);
            return _action.Rotate(position, (Instruction)instruction);
        }
    }
}

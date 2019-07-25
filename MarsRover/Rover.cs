namespace MarsRover
{
    public class Rover
    {
        public Rover(int xCoordinate,int yCoordinate,char direction)
        {
            CurrentPosition = new RoverPosition(xCoordinate, yCoordinate, (Directions)direction);
        }

        public RoverPosition CurrentPosition { get; set; }
    }
}

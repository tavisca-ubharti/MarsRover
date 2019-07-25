namespace MarsRover
{
    public class RoverPosition
    {
        public RoverPosition(int x,int y,Directions direction)
        {
            XCoordinate = x;
            YCoordinate = y;
            CurrentDirection = direction;
        }

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Directions CurrentDirection { get; set; }
    }
}

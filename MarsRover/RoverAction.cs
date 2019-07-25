namespace MarsRover
{
    public class RoverAction
    {
        public RoverPosition MoveForward(RoverPosition position)
        {
            var newPosition = new RoverPosition(position.XCoordinate,position.YCoordinate,position.CurrentDirection);
            switch(newPosition.CurrentDirection)
            {
                case Directions.East:
                    newPosition.XCoordinate += 1;
                    break;
                case Directions.South:
                    newPosition.YCoordinate -= 1;
                    break;
                case Directions.West:
                    newPosition.XCoordinate -= 1;
                    break;
                case Directions.North:
                    newPosition.YCoordinate += 1;
                    break;
                case Directions.NorthEast:
                    newPosition.XCoordinate += 1;
                    newPosition.YCoordinate += 1;
                    break;
                case Directions.SouthWest:
                    newPosition.XCoordinate -= 1;
                    newPosition.YCoordinate -= 1;
                    break;
                case Directions.SouthEast:
                    newPosition.XCoordinate += 1;
                    newPosition.YCoordinate -= 1;
                    break;
                case Directions.NorthWest:
                    newPosition.XCoordinate -= 1;
                    newPosition.YCoordinate += 1;
                    break;
            }
            if (IsNotValidPositionOnMap(newPosition))
                return position;
            return newPosition;
        }

        private bool IsNotValidPositionOnMap(RoverPosition newPosition)
        {
            var xCoordinate = newPosition.XCoordinate;
            var yCoordinate = newPosition.YCoordinate;
            if (xCoordinate < 0 || yCoordinate < 0 ||xCoordinate>Map.MaxXCoordinate||yCoordinate>Map.MaxYCoordinate)
                return true;
            return false;
        }

        public RoverPosition Rotate(RoverPosition position,Instruction instruction)
        {
            if (Instruction.Left == instruction)
                return GetPositionOnLeftRotate(position);
            return GetPositionOnRightRotate(position);
        }

        private RoverPosition GetPositionOnRightRotate(RoverPosition position)
        {
            switch(position.CurrentDirection)
            {
                case Directions.East:
                    position.CurrentDirection = Directions.South;
                    break;
                case Directions.South:
                    position.CurrentDirection = Directions.West;
                    break;
                case Directions.West:
                    position.CurrentDirection = Directions.North;
                    break;
                case Directions.North:
                    position.CurrentDirection = Directions.East;
                    break;
                case Directions.NorthEast:
                    position.CurrentDirection = Directions.SouthEast;
                    break;
                case Directions.SouthWest:
                    position.CurrentDirection = Directions.NorthWest;
                    break;
                case Directions.SouthEast:
                    position.CurrentDirection = Directions.SouthWest;
                    break;
                case Directions.NorthWest:
                    position.CurrentDirection = Directions.NorthEast;
                    break;
            }
            return position;
        }

        private RoverPosition GetPositionOnLeftRotate(RoverPosition position)
        {
            switch (position.CurrentDirection)
            {
                case Directions.East:
                    position.CurrentDirection = Directions.North;
                    break;
                case Directions.South:
                    position.CurrentDirection = Directions.East;
                    break;
                case Directions.West:
                    position.CurrentDirection = Directions.South;
                    break;
                case Directions.North:
                    position.CurrentDirection = Directions.West;
                    break;
                case Directions.NorthEast:
                    position.CurrentDirection = Directions.NorthWest;
                    break;
                case Directions.SouthWest:
                    position.CurrentDirection = Directions.SouthEast;
                    break;
                case Directions.SouthEast:
                    position.CurrentDirection = Directions.NorthEast;
                    break;
                case Directions.NorthWest:
                    position.CurrentDirection = Directions.SouthWest;
                    break;
            }
            return position;
        }
    }
}

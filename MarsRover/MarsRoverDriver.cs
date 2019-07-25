using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class MarsRoverDriver
    {
        private Rover _rover;
        private RoverCommand _roberCommand;
        public string TakeInput(List<string> inputList)
        {
            var output = String.Empty;   
            _roberCommand = new RoverCommand();
            var mapDimension = inputList[0].Split(' ');
            Map.MaxXCoordinate = int.Parse(mapDimension[0]);
            Map.MaxYCoordinate = int.Parse(mapDimension[1]);
            var initialPosition = inputList[1].Split(' ');
            _rover = new Rover(int.Parse(initialPosition[0]),int.Parse(initialPosition[1]),char.Parse(initialPosition[2]));
            var instructionList = inputList[2];
            foreach (var command in instructionList)
                _rover.CurrentPosition = _roberCommand.GetUpdatedPositionOnExecutingCommand(command, _rover.CurrentPosition);
            output = $"{_rover.CurrentPosition.XCoordinate} {_rover.CurrentPosition.YCoordinate} {(char)_rover.CurrentPosition.CurrentDirection}";
            return output;
        }
    }


}

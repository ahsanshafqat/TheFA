using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TheFA.Core.Commands;
using TheFA.Core.Enums;

namespace TheFA.Core.Model
{
    public class Robot
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Direction Direction { get; set; }
        public IList<ICommand> Commands { get; private set; }
        public bool Processed { get; private set; }
        public bool IsWreck { get; set; }

        public void FinishedProcessing()
        {
            Processed = true;
        }


        public Robot(Position position, IList<ICommand> commands)
        {
            XCoordinate = position.X;
            YCoordinate = position.Y;
            Direction = position.Direction;
            IsWreck = false;
            Processed = false;
            Commands = commands;
        }

    }
}

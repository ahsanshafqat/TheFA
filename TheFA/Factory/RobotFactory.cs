using System;
using System.Linq;
using TheFA.Core.Enums;
using TheFA.Core.Model;

namespace TheFA.Core.Factory
{
    public class RobotFactory
    {
        private readonly ICommandFactory commandFactory;

        public RobotFactory(ICommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }
        public Robot Build(string robotStartingPositionInput, string robotCommandInput)
        {
            if (robotStartingPositionInput == string.Empty)
            {
                throw new ArgumentNullException("Robot start position is required");
            }
            var robotStartingPosition = robotStartingPositionInput.Split(' ');
            var commands = commandFactory.Build(robotCommandInput);
            var position = new Position(int.Parse(robotStartingPosition.ElementAt(0)), int.Parse(robotStartingPosition.ElementAt(1)), (Direction)(Enum.Parse(typeof(Direction), robotStartingPosition.ElementAt(2))));
            var robot = new Robot(position, commands);

            return robot;
        }
    }
}

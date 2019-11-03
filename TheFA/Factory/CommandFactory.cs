using System.Collections.Generic;
using TheFA.Core.Commands;
using TheFA.Core.Exceptions;

namespace TheFA.Core.Factory
{
    public class CommandFactory : ICommandFactory
    {
        public IList<ICommand> Build(string robotCommandsInput)
        {
            IList<ICommand> commands = new List<ICommand>();

            foreach (var commandInput in robotCommandsInput.ToCharArray())
            {
                ICommand command;
                switch (commandInput)
                {
                    case 'R':
                        command = new RightCommand();
                        break;
                    case 'L':
                        command = new LeftCommand();
                        break;
                    case 'M':
                        command = new MoveCommand();
                        break;
                    default:
                        throw new InvalidRobotCommandException();
                }
               commands.Add(command);
            }
            return commands;
        }
    }
}

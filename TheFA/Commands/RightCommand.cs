using TheFA.Core.Enums;
using TheFA.Core.Model;

namespace TheFA.Core.Commands
{
   public class RightCommand : ICommand {

       public void Execute(Robot robot, Arena arena) {
            switch (robot.Direction)
            {
                case Direction.N:
                    robot.Direction = Direction.E;
                    break;
                case Direction.E:
                    robot.Direction = Direction.S;
                    break;
                case Direction.S:
                    robot.Direction = Direction.W;
                    break;
                case Direction.W:
                    robot.Direction = Direction.N;
                    break;
            }
        }
    }
}



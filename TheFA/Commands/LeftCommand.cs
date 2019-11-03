using TheFA.Core.Model;

namespace TheFA.Core.Commands
{
   public class LeftCommand : ICommand {

       public void Execute(Robot robot, Arena areana) {
            switch (robot.Direction)
            {
                case Direction.N:
                    robot.Direction = Direction.W;
                    break;
                case Direction.E:
                    robot.Direction = Direction.N;
                    break;
                case Direction.S:
                    robot.Direction = Direction.E;
                    break;
                case Direction.W:
                    robot.Direction = Direction.S;
                    break;
            }
        }
    }
}

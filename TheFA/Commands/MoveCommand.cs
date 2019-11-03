using System.Linq;
using TheFA.Core.Exceptions;
using TheFA.Core.Model;

namespace TheFA.Core.Commands
{
    public class MoveCommand : ICommand
    {


        public void Execute(Robot robot, Arena arena)
        {

            if ((robot.Direction == Direction.W && robot.XCoordinate == 0)
                    || (robot.Direction == Direction.S && robot.YCoordinate == 0)
                    || (robot.Direction == Direction.N && robot.YCoordinate == arena.UpperBoundY)
                    || (robot.Direction == Direction.E && robot.XCoordinate == arena.UpperBoundX)
                )
            {
                throw new InvalidMoveException();
            }

           

            //foreach (var areaRobot in )
            //{
            //    if (//robot != areaRobot &&
            //        //areaRobot.Processed==true &&
            //        robot.XCoordinate == areaRobot.XCoordinate && 
            //        robot.YCoordinate == areaRobot.YCoordinate)
            //    {
            //        robot.IsWreck = true;
            //    }
            //}

            if (robot.IsWreck)
                return;

            switch (robot.Direction)
            {
                case Direction.N:
                    robot.YCoordinate++;
                    break;
                case Direction.E:
                    robot.XCoordinate++;
                    break;
                case Direction.S:
                    robot.YCoordinate--;
                    break;
                case Direction.W:
                    robot.XCoordinate--;
                    break;
            }


        }
    }
}

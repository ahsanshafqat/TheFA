using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFA.Core.Model;

namespace TheFA.Core
{
    public class Game
    {
        public void Start(Arena arena)
        {
            foreach (var robot in arena.Robots)
            {

                if (robot.IsWreck == false)
                    foreach (var robotCommand in robot.Commands)
                    {
                        robotCommand.Execute(robot, arena);
                        CheckIsWreck(robot, arena);
                    }
                robot.FinishedProcessing();
            }
        }

        public void CheckIsWreck(Robot robot, Arena arena)
        {
            var samePosition = arena.Robots.FirstOrDefault(x => x.Processed &&
                                                                x.XCoordinate == robot.XCoordinate &&
                                                                x.YCoordinate == robot.YCoordinate);

            if (samePosition != null)
            {
                robot.IsWreck = true;
            }

        }
    }
}

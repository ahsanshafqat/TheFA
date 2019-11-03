using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TheFA.Core;
using TheFA.Core.Factory;
using TheFA.Core.Model;

namespace TheFA.Console
{
    class Program
    {

        static void Main(string[] args)
        {
            //Initialize dependancy Builder
            var kernel = new StandardKernel();
            kernel.Load(Assembly.LoadFrom("TheFA.Core.DLL"));

            var arenaFactory = new ArenaFactory();
            var robotParser = new RobotFactory(new CommandFactory());
            var commandFactory = new CommandFactory();

            //Build Arena
            string areanaInput = "7 6";
            var arena = arenaFactory.Build(areanaInput);

            //Create robot A
            var robotStartLocation_A = "2 4 E";
            var robotCommands_A = "MMRMMRMRRM";
            var robotA = robotParser.Build(robotStartLocation_A, robotCommands_A);

            //Create robot B
            var robotStartLocation_B = "3 4 N";
            var robotCommands_B = "LMLMLMLMM";
            var robotB = robotParser.Build(robotStartLocation_B, robotCommands_B);

            //Add robot to arena
            arena.Robots.Add(robotA);
            arena.Robots.Add(robotB);

            //Create and Start game
            var game = new Game();
            game.Start(arena);

            foreach (var finalRobot in arena.Robots)
            {
                System.Console.WriteLine(string.Format("{0} {1} {2}", finalRobot.XCoordinate, finalRobot.YCoordinate, finalRobot.IsWreck ? "Wreck" : finalRobot.Direction.ToString()));
            }
            System.Console.ReadLine();

        }

    }
}

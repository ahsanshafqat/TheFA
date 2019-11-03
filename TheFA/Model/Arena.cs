using System.Collections.Generic;

namespace TheFA.Core.Model
{
    public class Arena
    {
        public List<Robot> Robots { get; private set; }
        public uint UpperBoundX {get;}
        public uint UpperBoundY { get; }

        public Arena(Coordinates coordinates)
        {
            UpperBoundX = coordinates.X;
            UpperBoundY = coordinates.Y;
            Robots = new List<Robot>();
        }
    }
}

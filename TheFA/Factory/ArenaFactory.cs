using System.Linq;
using TheFA.Core.Model;

namespace TheFA.Core.Factory
{
    public class ArenaFactory
    {
        public Arena Build(string arenaInput) {
            
            var arenaBounds = arenaInput.Split().Select(uint.Parse);
            var coordinates = new Coordinates(arenaBounds.ElementAt(0), arenaBounds.ElementAt(1));
            
            var arena = new Arena(coordinates);

            return arena;
        }

    }
}

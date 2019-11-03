using TheFA.Core.Model;

namespace TheFA.Core.Commands
{
    public interface ICommand
    {
        void Execute(Robot robot, Arena arena);
    }
}

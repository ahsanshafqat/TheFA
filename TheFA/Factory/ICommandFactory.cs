using System.Collections.Generic;
using TheFA.Core.Commands;

namespace TheFA.Core.Factory
{
    public interface ICommandFactory
    {
        IList<ICommand> Build(string robotCommandsInput);
    }
}
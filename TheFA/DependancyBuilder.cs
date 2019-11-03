using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheFA.Core.Factory;

namespace TheFA.Core
{
    public class DependancyBuilder : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommandFactory>().To<CommandFactory>();

        }
    }
}

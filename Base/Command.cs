using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warrior.Interface;
using Warrior.Options;

namespace Warrior.Base
{
    internal abstract class Command : ICommand
    {
        internal abstract List<ICommand> Commands { get; }

        internal static CommandLineOptions Options { get; set; }

        internal static CommandLineApplication App { get; set; }

        public virtual void Configure()
        {
            foreach (ICommand command in Commands)
            {
                command.Configure();
            }
        }

        public abstract void Run(CommandLineApplication app);
    }
}

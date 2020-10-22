using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warrior.Base;
using Warrior.Commands.Ninja;
using Warrior.Interface;

namespace Warrior.Commands
{
    internal class NinjaCommand : Command
    {
        static ICommand[] subCommands = new ICommand[]
        {
            new HideCommand(),
            new RunCommand()
        };

        internal override List<ICommand> Commands => subCommands.ToList();

        public override void Run(CommandLineApplication app)
        {
            Console.WriteLine("Ninja Command");
        }

        public override void Configure()
        {

            App.Command("ninja", c => NinjaCommand.Conf(App, c));

            base.Configure();
        }

        private static void Conf(CommandLineApplication app, CommandLineApplication c)
        {
            c.Command("ninja", asd);
        }

        private static void asd(CommandLineApplication obj)
        {
            Console.WriteLine("SAASDASD");
        }
    }
}

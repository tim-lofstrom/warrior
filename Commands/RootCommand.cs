using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warrior.Base;
using Warrior.Interface;
using Warrior.Options;

namespace Warrior.Commands
{
    internal class RootCommand : Command
    {
        static ICommand[] subCommands = new ICommand[]
        {
            new NinjaCommand()
        };

        public RootCommand(CommandLineApplication app)
        {
            App = app;
        }

        internal override List<ICommand> Commands => subCommands.ToList();

        public override void Run(CommandLineApplication app)
        {
            while (true)
            {
                if (Options.Interactive)
                {
                    Console.Write("warrior>");
                    string args = Console.ReadLine();

                    try
                    {
                        app.Execute(args);
                    }
                    catch (Exception e)
                    { 
                    }

                    continue;
                }

            }
        }

        public override void Configure()
        {

            Options = new CommandLineOptions();
            Options.Interactive = true;

            //app.Command("greet", c => GreetCommand.Configure(app, c));


            base.Configure();
        }
    }
}

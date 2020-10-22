using System;
using Microsoft.Extensions.CommandLineUtils;
using Warrior.Base;
using Warrior.Commands;
using Warrior.Commands.Ninja;

namespace Warrior
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "warrior",
                FullName = "Warrior Console Application.",
                Description = "The most awesome warrior application in history of console warrior applications."
            };

            var rootCommand = new RootCommand(app);

            rootCommand.Configure();

            rootCommand.Run(app);

        }
    }
}

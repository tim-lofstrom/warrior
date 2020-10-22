using Microsoft.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warrior.Base;
using Warrior.Interface;

namespace Warrior.Commands.Ninja
{
    class RunCommand : ICommand
    {
        public void Configure()
        {
        }

        public void Run(CommandLineApplication app)
        {
            Console.WriteLine("Run RunCommand");
        }
    }
}

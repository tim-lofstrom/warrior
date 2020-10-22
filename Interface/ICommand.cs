using Microsoft.Extensions.CommandLineUtils;

namespace Warrior.Interface
{
    internal interface ICommand
    {
        void Run(CommandLineApplication app);

        void Configure();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Commands
{
    public class KillCommand : IGlobalCommand
    {
        public string CommandName { get; } = "kill";

        public KillCommand() { }

        public void ExecuteGlobalCommand(string[] args)
        {
            // Check if there are any arguments provided
            if (args.Length == 0)
            {
                Console.WriteLine("Kill what?");
                return;
            }

            // Check if more than one argument is provided
            if (args.Length > 1)
            {
                Console.WriteLine($"I don't understand 'kill {string.Join(' ', args)}'.");
                return;
            }

            // Get the target name
            string target = args[0].ToLower();

            switch (target)
            {
                case "guard":
                    Console.WriteLine("Combat with the guard begins!");
                    break;
                default:
                    Console.WriteLine($"I don't understand 'kill {target}'.");
                    break;
            }
        }
    }
}

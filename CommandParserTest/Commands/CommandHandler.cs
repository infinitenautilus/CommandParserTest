using CommandParserTest.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Core
{
    public class CommandHandler
    {
        private static readonly Lazy<CommandHandler> lazyInstance = new Lazy<CommandHandler>(() => new CommandHandler());
        
        public static CommandHandler Instance 
        { 
            get 
            { 
                return lazyInstance.Value; 
            } 
        }

        private Dictionary<string, IGlobalCommand> globalCommands = new();

        private CommandHandler()
        {
            RegisterCommand(new ScoreCommand());

            RegisterCommand(new KillCommand());
        }

        public bool Handle(string command, string[] args)
        {
            if (globalCommands.TryGetValue(command, out IGlobalCommand? cmd))
            {
                if (cmd == null)
                {
                    Console.WriteLine("Found null input.");
                    return false;
                }
             
                cmd.ExecuteGlobalCommand(args);
                return true;
            }

            return false;
        }

        private void RegisterCommand(IGlobalCommand command)
        {
            globalCommands[command.CommandName] = command;
        }
    }
}

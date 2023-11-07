using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Commands
{
    public class ScoreCommand : IGlobalCommand
    {
        public string CommandName { get; } = "score";

        public void ExecuteGlobalCommand(string[] args)
        {
            Console.WriteLine("You run score...");
        }
    }
    
}

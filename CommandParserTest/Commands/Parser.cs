using CommandParserTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandParserTest.Commands
{
    public class Parser
    {
        private static readonly Lazy<Parser> lazyInstance = new Lazy<Parser>(() => new Parser());

        public static Parser Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        private Parser()
        {

        }

        public void Parse(string inputString)
        {
            string[] tokens = inputString.Split(' ');
            string mainCommand = tokens[0];
            string[] args = new string[tokens.Length - 1];

            Array.Copy(tokens, 1, args, 0, args.Length);

            if(CommandHandler.Instance.Handle(mainCommand, args))
            {
                return;
            }

            Console.WriteLine("Command not recognized.");
        }
    }
}

using CommandParserTest.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Commands.Efuns
{
    public class Printer
    {
        private Lazy<Printer> instance = new Lazy<Printer>(() => new Printer());

        public Printer Instance { get { return instance.Value; } }

        public Printer()
        {

        }

        public void PrintMessageToRoom(string message, Agent talker)
        {
            Room area = talker.MyCurrentRoom;

            foreach(Agent c in area.MyAgentContents)
            {
                if(talker == c)
                {
                    Console.WriteLine($"You say, {message}.");
                }
                else
                {
                    Console.WriteLine($"{talker.ShortDescription} says, '{message}'");
                }
            }
        }
    }
}

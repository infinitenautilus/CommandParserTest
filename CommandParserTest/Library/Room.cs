using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Library
{
    public class Room
    {
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public List<Item> MyItemContents { get; set; }
        //public List<Player> MyPlayerContents { get; set; }
        public List<Agent> MyAgentContents { get; set; }



        public Room()
        {
            ShortDescription = "Default Room";
            LongDescription = "This is the default room class object.";
            MyItemContents = new();
            MyAgentContents = new();
            //MyPlayerContents = new();
        }


    }
}

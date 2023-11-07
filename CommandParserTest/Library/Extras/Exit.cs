using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Library.Extras
{
    public class Exit
    {
        public string ExitDirection { get; set; }
        public string ExitFile { get; set; }
        public int ExitRoomID { get; set; }

        public Exit(string direction, string exitfile)
        {
            ExitDirection = direction;
            ExitFile = exitfile;

            return;
        }
    }
}

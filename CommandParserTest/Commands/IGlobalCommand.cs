using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Commands
{
    public interface IGlobalCommand
    {
        string CommandName { get; }
        public void ExecuteGlobalCommand(string[] args);
    }
}

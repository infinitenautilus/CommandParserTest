using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Library
{
    public class Construct
    {

        public string PrimaryNoun { get; set; }
        public List<string> Nouns { get; set; }
        public List<string> Adjectives { get; set; }
        public Dictionary<string, Action> Verbs { get; set; }
        public string LongDescription { get; set; }
        public string ShortName { get; set; }

        public Construct()
        {
            PrimaryNoun = "construct";
            ShortName = "Construct Class";
            Adjectives = new();
            Verbs = new();
            Nouns = new();
            LongDescription = "This is the construct class in it's bare form.";


        }
    }
}

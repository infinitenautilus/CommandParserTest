using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Library
{
    public enum CreatureSize
    {
        Tiny = 0,
        Small = 1,
        Medium = 2,
        Large = 3,
        Huge = 4,
        Giant = 5
    }

    public class Agent
    {
        public string ShortDescription { get; set; } = "Agent Class";
        public string LongDescription { get; set; } = "This is the base Agent Class.";

        public List<string> Nouns = new();
        public List<string> Adjectives = new();
        public List<Item> MyInventory = new();

        public Room MyCurrentRoom { get; set; } = new();
        public Room MyPreviousRoom { get; set; } = new();

        public bool CanBePickedUp { get; set; }
        public CreatureSize Size { get; set; }
        
        public Agent(string shortName, string desc, List<string> nouns, List<string> adj, Room curRoom)
        {
            ShortDescription = shortName;
            LongDescription = desc;
            Nouns = nouns;
            Adjectives = adj;
            MyCurrentRoom = curRoom;
            MyPreviousRoom = curRoom;
        }

        public void HeartbeatPulse()
        {

        }

        public void Speak(string message)
        {

        }

        public void Spawn()
        {

        }

        public void UpdateMyInventory(List<Item> itemsToInsert)
        {
            MyInventory.Clear();
            MyInventory = itemsToInsert;
        }
    }
}

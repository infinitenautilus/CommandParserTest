using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Library
{
    public class Item
    {
        public string ShortDescription { get; set; } = "Item Class";
        public string LongDescription { get; set; } = "This is an item class object.";

        public List<string> Adjectives { get; set; } = new();
        public List<string> Nouns { get; set; } = new();
        public List<string> Verbs { get; set; } = new();
        
        private float enchantmentPercent = 0.0f;
        
        public float EnchantmentPercent
        {
            get
            {
                return enchantmentPercent;
            }
            set
            {
                if(value < 0.00f)
                {
                    enchantmentPercent = 0.01f;
                }
                else if (value > 1.0f)
                {
                    enchantmentPercent = 1.0f;
                }
                else
                {
                    enchantmentPercent = value;
                }
                enchantmentPercent = value;
            }
        }
        
        public int Weight { get; set; }
        
        public bool CanPickUp { get; set; }
        public bool CanDropItem { get; set; }
        public bool CannotDropOnDeath { get; set; }

        public ItemSize Size { get; set; }


        public Item()
        {

        }

        public Item(string shortDesc, string longDesc, int weight, ItemSize size, bool canPickUp, bool canDrop, bool cannotDropOnDeath)
        { 
            ShortDescription = shortDesc;
            LongDescription = longDesc;
            Weight = weight;
            Size = size;
            CanPickUp = canPickUp;
            CanDropItem = canDrop;
            CannotDropOnDeath = cannotDropOnDeath;
        }
    }
}

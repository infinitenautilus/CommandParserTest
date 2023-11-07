using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParserTest.Library
{
    public class Container : Item
    {
        public List<Item> MyItemInventory = new();

        public bool CanOpen { get; set; }
        public bool IsOpen { get; set; }

        public ItemSize StorageSize { get; set; }

        public Container() { }

        public Container(string name, string desc, int weight, ItemSize itemSize, ItemSize storageSize)
        {
            ShortDescription = name;
            LongDescription = desc;
            Weight = weight;

            Size = itemSize;
            StorageSize = storageSize;
        }
    }
}

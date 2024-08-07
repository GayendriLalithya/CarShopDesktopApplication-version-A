using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Entity
{
    public class Item
    {
        // Attributes of the Item class
        public int? itemid {  get; set; }
        public string itemtype { get; set; } = string.Empty;

        // default Constructor
        public Item()
        {
            // the constructor
        }

        // Parameterised Constructor
        public Item (int itemid, string itemtype)
        {
            this.itemid = itemid;
            this.itemtype = itemtype;
        }

        public Item(int itemid)
        {
            this.itemid = itemid;
        }

        // Behaviors Methods of the Item class
        public void DisplayItemDetails()
        {
            // Display item by its type logic
        }
    }
}

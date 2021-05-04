using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingList.Core
{
    public class Item
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public bool InPromotion { get; set; } 

    }
}

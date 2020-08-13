using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLibrary
{
   public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<item> Items { get; set; }

        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<item>();
        }
    }
}

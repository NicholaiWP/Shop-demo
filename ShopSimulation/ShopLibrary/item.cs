using System;
using System.Collections.Generic;
using System.Text;

namespace ShopLibrary
{
    public class item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public Vendor Owner { get; set; }

        public string Display
        {
            get
            {
                return String.Format("{0} - ${1}", Title, Price);
            }
        }

        public item()
        {

        }
    }
}

using System;

namespace ShopLibrary
{
    public class Vendor { 
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }


        public string Display
        {
            get
            {
                return String.Format("{0} {1} - ${2}", FirstName, LastName, PaymentDue);
            }
        }

        public Vendor(string firstName, string lastName, double commission)
        {
            FirstName = firstName;
            LastName = lastName;
            Commission = commission;
        }

    }
}

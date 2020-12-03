using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Address
    {
        public Address()
        {
            Address1 = "unknown";
            Street = "unknown";
            City = "unknown";
            Country = "unknown";
        }

        public Address ( string address1, string street, string city, string country)
        {
            Address1 = address1;
            Street = street;
            City = city;
            Country = country;
        }

        public string Address1 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return Address1 + " " +  Street + " " + City + " " + Country;
        }
    }
    
}

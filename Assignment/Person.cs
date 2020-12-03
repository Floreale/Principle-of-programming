using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Person
    {
        private  string firstName;
           private string lastName;
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public Person()
        {
            //FirstName = "unknown";
            //LastName = "unknown";
        }
        public Person(string firstName, string lastName )
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}

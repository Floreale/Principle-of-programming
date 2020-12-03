using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Student : Person
    {
        private string studentNumber;
        private int age;
        private Address address;
        private string fullName;
        private string fullAddress;
        private int moyenne;

        public string StudentNumber { get { return this.studentNumber; } set { this.studentNumber = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public Address Address { get { return this.address; } set { this.address = value; } }
        public string FullName { get { return this.fullName; } set { this.fullName = value; } }
        public string FullAddress { get { return this.fullAddress; } set { this.fullAddress = value; } }

        public int Moyenne { get { return this.moyenne; } set { this.moyenne = value; } }

        public Student(string studentNumber, int age, Address address, string firstName, string lastName, string fullAddress) :base(firstName, lastName)
        {
            this.studentNumber = studentNumber;
            this.age = age;
            this.address = address;
            this.fullName = FirstName + " " + LastName;
            this.fullAddress = address.ToString();
        }

        public int ScoresExam()
        {
            Console.WriteLine("How many notes did you get ?");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter your notes one by one");
                int note = Convert.ToInt32(Console.ReadLine());
                tab[i] = note;

            }
            int total = 0;
            for (int i = 0; i < lenght; i++)
            {
                total = tab[i] + total;
            }
            Moyenne = total / tab.Length;
            return Moyenne;

        }

        public override string ToString()
        {

            return $"Here you can see all the information you fullfilled : \nFull Name : {FullName}\nStudent Number : {studentNumber}\nAge : {Age}\nAddress : {FullAddress}\n{fullName}your final score is : {moyenne}\n ";

        }

    }
}

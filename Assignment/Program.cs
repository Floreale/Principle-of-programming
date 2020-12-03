using System;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I need your help to get all your student informations. \nSo first we are going to start with your first name.");
            string FirstName = Console.ReadLine();
            Console.WriteLine("\nThen can you tell me your last name.");
            string LastName = Console.ReadLine();
            Console.WriteLine("\nNow it's time to write down your student number.");
            string StudentNumber = Console.ReadLine();
            Console.WriteLine("\nAnd how old are you my dear ? ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nAnd Where do you live ? Start with your country.");
            string Country = Console.ReadLine();
            Console.WriteLine("\nThe city ?");
            string City = Console.ReadLine();
            Console.WriteLine("\nThe street ? ");
            string Street = Console.ReadLine();
            Console.WriteLine("\nThe number of the street ? ");
            string Address1 = Console.ReadLine();

            Address Ad = new Address(Address1, Street, City, Country);
             Student Student1 = new Student(StudentNumber, Age, Ad, FirstName, LastName, "");

            Console.WriteLine("\nLet me know your scores at the exam.");

            Student1.ScoresExam();
            Console.WriteLine(Student1.ToString());





            Console.ReadKey();
        }
    }
}

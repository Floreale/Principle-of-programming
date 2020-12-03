using System;

namespace POP_class4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo menu;
            do
            {
                Console.Clear();
                Console.Write("Menu : \n"
                    + " exercice 2 : triangle with asterix\n"
                    + " exercice 3 : Triangle with number \n"
                    + " exercice 4 : pyramide \n"
                );

                Console.WriteLine("\nThe user must enter an exercice number ");
                int exercice = int.Parse(Console.ReadLine());
                switch (exercice)
                {
                    case 2:
                        Console.WriteLine("\n Exercice 2 : \n");
                        trianglasterix();
                        
                    break;
                    case 3:
                        Console.WriteLine("\n Exercice 3 : \n ");
                        trianglenumber();
                        
                        break;
                    case 4:
                        Console.WriteLine("\n Exercie 4 : \n");
                        Diamond();
                        break;
                        
                    default:
                        Console.WriteLine("The number enter is out of range");

                        break;

                }
                Console.WriteLine("If you want to leave the menu you must click on escape otherwise click on any letter");
                menu = Console.ReadKey();
            }
            while (menu.Key != ConsoleKey.Escape);

            Console.WriteLine("Hello World!");
        }
        static void trianglasterix()
        {
            for (int i=1; i<5; i++ )
            {
                int tampon = 0;
                tampon = i;

                while (tampon !=0)
                {
                    Console.Write("*");
                    tampon--;
                }
                Console.WriteLine();
            }
        }
        static void trianglenumber()
        {
            Console.WriteLine("Choose a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            for ( int i=1; i<5; i++)
            {
                int tampon = 0;
                tampon = i; 
                
                while (tampon !=0)
                {
                    Console.Write(number);
                    tampon--;

                }
                Console.WriteLine();
            }
        }
        static void Pyramide()
        {
            Console.WriteLine("What's the size of your pyramid ? ");
            int taille = int.Parse(Console.ReadLine());
            for (int i=0; i<taille; i++)
            {
                int tampon = taille - i;
                
                while (tampon != 1 )
                {
                    Console.Write(" ");
                    tampon--;
                }
                Console.ReadKey();
                for (int j=1; j<taille; i++)
                {
                    int mémoire = j;
                    while (mémoire != taille)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                        mémoire++; 
                    }
                    Console.ReadKey();
                }
              
                Console.ReadKey();

                Console.Write("\n");
                
            }
        }
        private static void Diamond ()
        {
            Console.WriteLine("Enter the height of your pyramid, it must be an odd number.");
            int height = int.Parse(Console.ReadLine());
            int gap = (height - 1) / 2;
            int filled = height;

            // UPPER PART
            for (int i = 1; i < height; i += 2)
            {
                for (int j = gap; j > 0; j--)
                {
                    Console.Write("+");
                }
                Console.ReadKey(); 
                gap--;
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }

            // MIDDLE LINE
            for (int i = 1; i <= height; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


            //LOWER PART
            gap = 1;

            for (int i = height; i > 1; i -= 2)
            {
                for (int j = 1; j <= gap; j++)
                {
                    Console.Write("+");
                }
                gap++;

                for (int k = 2; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

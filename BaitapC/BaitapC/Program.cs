using System;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Menu();
            Program.Nhap(n);
            Console.Readkey(); 
		}
        static void Menu()
        {
            System.Console.WriteLine("+=========================+\n");
            System.Console.WriteLine("'           Menu          '\n");
            System.Console.WriteLine("+=========================+\n");
            System.Console.WriteLine("' 1. Menu 1               '\n");
            System.Console.WriteLine("' 2. Menu 2               '\n");
            System.Console.WriteLine("' 3. Menu 3               '\n");
            System.Console.WriteLine("' 4. Menu 4               '\n");
            System.Console.WriteLine("' 5. Menu 5               '\n");
            System.Console.WriteLine("+=========================+\n");
            System.Console.WriteLine("        Please Choose:     \n");
        

        }
        static void Nhap(char n)
        {
            do
            {
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1: System.Console.WriteLine(" Menu 1 ..."); break;
                    case 2: System.Console.WriteLine(" Menu 2 ..."); break;
                    case 3: System.Console.WriteLine(" Menu 3 ..."); break;
                    case 4: System.Console.WriteLine(" Menu 4 ..."); break;
                    case 5: System.Console.WriteLine(" Menu 5 ..."); break;
                    default:Console.WriteLine(" incorrect, re enter..."); break;

                }
            } while ( n != 5);
            return;
        }
    }
}

using System;

namespace System
{
    class testttttt
    {
        public static void Main()
        {

            Console.Write("\n");
            Console.Write("Kiem tra so nguyen to:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");
            int[] a = new int[10];

            for (int i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(a[i] + " ");
                int number;
            int bien_dem = 0;

            Console.Write("Nhap mot so can kiem tra: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    bien_dem++;

            if (bien_dem == 2)
                Console.WriteLine("la so nguyen to.");
            else
                Console.WriteLine("khong phai la so nguyen to.");

            Console.ReadKey();
        }
    }
}
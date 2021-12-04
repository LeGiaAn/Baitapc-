using System;

namespace Baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int k = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == k)
                {
                    count++;
                }
            }
            Console.Write(count);
        }
    }
}

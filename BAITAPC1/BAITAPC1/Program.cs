using System;

namespace bailamc1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(i * 5 + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

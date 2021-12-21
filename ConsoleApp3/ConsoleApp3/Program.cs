using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char c = char.Parse(Console.ReadLine());
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) dem ++;
            }
            Console.WriteLine(dem);
        }
    }
}
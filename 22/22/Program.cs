using System;

namespace baitap
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					continue;
				}
				Console.Write(i + " ");
			}
		}
	}
}
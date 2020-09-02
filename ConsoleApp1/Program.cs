using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Salut Polo!");
			int a = 0b0001;
			int b = 0b0011;
			int c;

			c = a & b;
			Console.WriteLine("c=" + c.ToString());
		}
	}
}

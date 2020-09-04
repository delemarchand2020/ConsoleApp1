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

			Console.WriteLine("a: " + a.ToString() + " b: " + b.ToString());

			c = a & b;
			Console.WriteLine("c = a and b : " + c.ToString());
			c = a | b;
			Console.WriteLine("c = a or b : " + c.ToString());
		}
	}
}

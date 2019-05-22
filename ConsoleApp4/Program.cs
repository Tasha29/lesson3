using System;

namespace Lab1
{
	class Program
	{
		static void Main(string[] args)
		{

			double x = 1, y = 0;


			if (y == 0)
			{
				Console.WriteLine("Ошибка. Делитель не должен равняться нулю");
			}
			else
			{
				Console.WriteLine(x / y);
			}

			Console.WriteLine(y == 0 ? "Ошибка. Делитель не должен равняться нулю" : (x / y).ToString());


		}

	}
}

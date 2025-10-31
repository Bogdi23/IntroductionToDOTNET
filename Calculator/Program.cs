//#define CALC_IF
#define CALC_SWITCH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			string expression = "22+33-44/2+8*3";
			Console.WriteLine(expression);

			char[] operations = new char[] { '+', '-', '*', '/' };
			string[] operands = expression.Split(operations);
			for (int i = 0; i < operands.Length; i++)
			{
				Console.Write($"{operands[i]}\t");
			}
            Console.WriteLine();
			
        }

	}
}

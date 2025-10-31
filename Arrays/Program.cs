//#define ARRAY_1
//#define ARRAY_11
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random(0);    //Seed 

#if ARRAY_1
			int[] arr = { 3, 5, 8, 13, 21 };
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();

			foreach (var i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine(); 
#endif

#if ARRAY_11
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100, 200);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write($"{arr[i]}\t");
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");

			/*foreach (ref i in arr)
			{
				i = rand.Next(100);
			}
			
			foreach (int i in arr)
			{
				Console.Write($"{i}\t");
			}
            Console.WriteLine();*/ 
#endif

			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] arr = new int[rows, cols];

		}
	}
}

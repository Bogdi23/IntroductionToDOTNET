//#define CONSOLE
//#define NAME
using System;   //#include
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
			Console.WriteLine("Hello World!");
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			//Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write("Hello .NET\t");
			Console.WriteLine();
			Console.Title = "Introduction to .NET";
			Console.Beep(37, 2000);
			Console.CursorLeft = 25;
			Console.CursorTop = 5;
			Console.WriteLine("SetCursorPosition");
			Console.SetCursorPosition(22, 8);
			Console.WriteLine("Another position");
			Console.ResetColor();  
#endif

#if NAME
			Console.Write("Введите Ваше имя:");
			string firstName = Console.ReadLine();

			Console.Write("Введите Вашу фамилию: ");
			string lastName = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age);  //Конкатенация строк
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age));  //Форматирование строк
			Console.WriteLine($"{lastName} {firstName} {age}");     //Интерполяция строк  
#endif

			Console.Write("Введите число: ");
			int n = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\n1)");
			Square(n);

			Console.WriteLine("\n2)");
			RightTriangle(n);

			Console.WriteLine("\n3)");
			ReverseTriangle(n);

			Console.WriteLine("\n4)");
			ShiftedTriangle(n);

			Console.WriteLine("\n5)");
			MirroredTriangle(n);

			Console.WriteLine("\n6)");
			Rhombus(n);

			Console.WriteLine("\n7)");
			PlusMinus(n);
		}
		static void Square(int n)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
					Console.Write("* ");
				Console.WriteLine();
			}
		}

		static void RightTriangle(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 0; j < i; j++)
					Console.Write("* ");
				Console.WriteLine();
			}
		}

		static void ReverseTriangle(int n)
		{
			for (int i = n; i >= 1; i--)
			{
				for (int j = 0; j < i; j++)
					Console.Write("* ");
				Console.WriteLine();
			}
		}

		static void ShiftedTriangle(int n)
		{
			for (int i = 0; i < n; i++)
			{
				for (int s = 0; s < i; s++)
					Console.Write("  ");
				for (int j = 0; j < n - i; j++)
					Console.Write("* ");
				Console.WriteLine();
			}
		}

		static void MirroredTriangle(int n)
		{
			for (int i = 1; i <= n; i++)
			{
				for (int s = i; s < n; s++)
					Console.Write("  ");
				for (int j = 0; j < i; j++)
					Console.Write("* ");
				Console.WriteLine();
			}
		}

		static void Rhombus(int n)
		{
			// Верхняя часть
			for (int i = 0; i < n; i++)
			{
				for (int s = i; s < n - 1; s++)
					Console.Write(" ");
				Console.Write("/");
				for (int j = 0; j < i * 2; j++)
					Console.Write(" ");
				Console.WriteLine("\\");
			}
			// Нижняя часть
			for (int i = n - 1; i >= 0; i--)
			{
				for (int s = i; s < n - 1; s++)
					Console.Write(" ");
				Console.Write("\\");
				for (int j = 0; j < i * 2; j++)
					Console.Write(" ");
				Console.WriteLine("/");
			}
		}

		static void PlusMinus(int n)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((i + j) % 2 == 0)
						Console.Write("+ ");
					else
						Console.Write("- ");
				}
				Console.WriteLine();
			}
		}
	}
}
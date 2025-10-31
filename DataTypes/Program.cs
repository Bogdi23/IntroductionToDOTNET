using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimiter = "\n------------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.WriteLine($"bool занимет {sizeof(bool)} Байт памяти, класс обвертка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			Console.WriteLine(delimiter);

            //////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine
				(
$@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значения в диапазоне
от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}"
				);
			//@"RAW-строка" - игнорирует все спец. символы ESC-последовательности, т.е., воспринимается как есть
			Console.WriteLine(delimiter);

            //////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine
				(
$@"byte занимает {sizeof(byte)} Байт памяти, и принимает значения в диапазоне
от {byte.MinValue} до {byte.MaxValue}, класс-обвертка {typeof(byte)}"
				);
			Console.WriteLine(delimiter);

			//////////////////////////////////////////////////////////////////////////////////////

			Console.WriteLine
				(
$@"sbyte занимает {sizeof(sbyte)} Байт памяти, и принимает значения в диапазоне
от {sbyte.MinValue} до {sbyte.MaxValue}, класс-обвертка {typeof(sbyte)}"
				);
			Console.WriteLine(delimiter);

			//////////////////////////////////////////////////////////////////////////////////////

			Console.WriteLine($@"float занимает {sizeof(float)} Байт памяти");		
		}
	}
}

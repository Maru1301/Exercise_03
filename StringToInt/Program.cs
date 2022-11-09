using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace StringToInt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value1 = "123";
			Console.WriteLine(value1.ToInt(0));

			string value2 = "abc";
			Console.WriteLine(value2.ToInt(0));
		}
	}
}

public static class StringExts
{
	public static int ToInt(this string value, int defaultValue)
	{
		bool isInt = int.TryParse(value, out int num);

		return isInt ? num : defaultValue;
	}
}

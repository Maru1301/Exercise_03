using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int32.IsOdd.IsEven
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool result = 2.IsEven();
			Console.WriteLine(result);
		}
	}
}

public static class IntExts
{
	public static bool IsOdd(this int num)
	{
		return num % 2 == 1;
	}

	public static bool IsEven(this int num)
	{
		return num % 2 == 0;
	}
}

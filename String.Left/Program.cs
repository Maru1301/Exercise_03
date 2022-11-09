using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Left
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = "I am a good boy.";
			string result = s.Left(3);

			Console.WriteLine(result);
		}
	}
}

public static class StringExts
{
	public static string Left(this string value, int Length)
	{
		if (string.IsNullOrEmpty(value))
		{
			return string.Empty;
		}else if(Length <= 0)
		{
			return string.Empty;
		}else if(value.Length <= Length)
		{
			return value;
		}

		return value.Substring(0, Length);
	}
}

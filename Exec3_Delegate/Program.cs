using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> source = new List<int>{1,2,3,4,5,6,7,8,9,10};
			Func<int, bool> func = x => x % 2 == 0;
			
			List<int> result = GetEvenItems(source, func);

			foreach(int item in result)
			{
				Console.WriteLine(item);
			}
		}
		
		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			List<int> result = new List<int>();
			foreach(int item in source)
			{
				if (func(item))
				{
					result.Add(item);
				}
			}
			return result;
		}
	}
}

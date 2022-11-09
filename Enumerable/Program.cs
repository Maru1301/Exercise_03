using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = Enumerable.Range(1, 10).ToArray();

			foreach(var num in nums){
				Console.WriteLine(num);
			}

			int[] nums2 = Enumerable.Range(10, 6).ToArray();

			foreach (var num in nums2)
			{
				Console.WriteLine(num);
			}
		}
	}
}

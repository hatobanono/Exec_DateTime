using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			int month = now.Month;
			int day = now.Day;

			Console.Write($"今天是{month}月{day}日 ");

			if (day <= 10)
			{
				Console.WriteLine("上旬");
			}
			else if (day >= 21)
			{
				Console.WriteLine("下旬");
			}
			else
			{
				Console.WriteLine("中旬");
			}
		}
	}
}

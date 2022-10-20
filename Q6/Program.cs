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
			string msg = string.Empty;

			if (day <= 10)
			{
				msg = "上旬";
			}
			else if (day >= 21)
			{
				msg = "下旬";
			}
			else
			{
				msg = "中旬";
			}

			Console.WriteLine(msg);
		}
	}
}

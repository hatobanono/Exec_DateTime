using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6.Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			int month = now.Month;
			int day = now.Day;
			int hour = now.Hour;

			Console.Write($"今天是{month}月{day}日 ");

			if (day <= 10)
			{
				Console.WriteLine("上旬");
			}
			else if(day >= 21)
			{
				Console.WriteLine("下旬");
			}
			else
			{
				Console.WriteLine("中旬");
			}

			Console.WriteLine($"現在時間{hour}時 ");

			if (hour >6 && hour <= 12)
			{
				Console.WriteLine("早上好");
			}else if(hour>12 && hour <= 18)
			{
				Console.WriteLine("下午好");
			}
			else
			{
				Console.WriteLine("晚上好");
			}

		}
	}
}

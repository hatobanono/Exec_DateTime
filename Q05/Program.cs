using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請指定年份: ");
			string input = Console.ReadLine();

			int year = Convert.ToInt32(input);

			DateTime firstDay = new DateTime(year, 1, 1);

			int weekday = (int)firstDay.DayOfWeek;
			DateTime firstSunday = firstDay.AddDays((7 - weekday) % 7);

			DateTime lastDay = new DateTime(year, 12, 31);
			for (DateTime i = firstSunday; i <= lastDay; i = i.AddDays(7))
			{
				Console.WriteLine(i.ToString("yyyy/MM/dd"));
			}


			//DateTime firstDayOfYear = new DateTime(Convert.ToInt32(input), 1, 1);
			////Console.WriteLine(firstDayOfYear);

			//DayOfWeek dayOfFirstDay = firstDayOfYear.DayOfWeek;
			//DateTime firstSunday = firstDayOfYear;
			//if ( (int)dayOfFirstDay > 0)
			//{
			//	firstSunday = firstDayOfYear.AddDays(7 - (int)dayOfFirstDay);
			//}
			////Console.WriteLine($"第一個禮拜天{firstSunday}");

			//DateTime lastDayOfYear = new DateTime(Convert.ToInt32(input), 12, 31);
			////Console.WriteLine(lastDayOfYear);

			//DayOfWeek dayOfLastDay = lastDayOfYear.DayOfWeek;
			//DateTime lastSunday = lastDayOfYear.AddDays(-(int)dayOfLastDay);
			////Console.WriteLine($"最後一個禮拜天{lastSunday}");

			//TimeSpan span = lastSunday - firstSunday;
			//int days = span.Days;
			//for (int i = 0; i <= days; i += 7)
			//{
			//	DateTime result = firstSunday.AddDays(i);
			//	Console.WriteLine($"{result:yyyy/MM/dd}");
			//}
		}
	}
}

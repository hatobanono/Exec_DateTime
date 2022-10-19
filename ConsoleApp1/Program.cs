using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime dvdReturn = today.AddDays(3);
			DateTime bookReturn = today.AddMonths(1);
			int month = today.Month;
			int year = today.Year;
			DateTime firstDayThisMonth = new DateTime(year, month, 1);
			DateTime lastDayThisMonth = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);

			Console.WriteLine($"1. DVD應歸還的時間為 {dvdReturn: yyyy/MM/dd}");
			Console.WriteLine($"2. 圖書應歸還的時間為 {bookReturn: yyyy/MM/dd}");
			Console.WriteLine($"3. 本月一日為 {firstDayThisMonth: yyyy/MM/dd}");
			Console.WriteLine($"4. 本月最後一日為 {lastDayThisMonth: yyyy/MM/dd}");

		}
	}
}

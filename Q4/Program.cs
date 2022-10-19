using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int month = today.Month;
			int year = today.Year;
			DateTime lastDayThisMonth = new DateTime(year, month, 1).AddMonths(1).AddDays(-1);
			Console.WriteLine($"本月最後一日為 {lastDayThisMonth: yyyy/MM/dd}");
		}
	}
}

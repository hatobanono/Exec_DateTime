﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			int month = today.Month;
			int year = today.Year;
			DateTime firstDayThisMonth = new DateTime(year, month, 1);
			Console.WriteLine($"本月一日為 {firstDayThisMonth: yyyy/MM/dd}");
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			DateTime today = DateTime.Today;
			DateTime bookReturn = today.AddMonths(1);
			Console.WriteLine($"圖書應歸還的時間為 {bookReturn: yyyy/MM/dd}");
		}
	}
}

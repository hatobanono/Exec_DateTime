using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime today = DateTime.Today;
			DateTime dvdReturn = today.AddDays(3);
			Console.WriteLine($"DVD應歸還的時間為 {dvdReturn: yyyy/MM/dd}");
		}
	}
}

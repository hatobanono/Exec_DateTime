using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DateTime now = DateTime.Now;
			int hour = now.Hour;

			Console.WriteLine($"現在時間{hour}時 ");

			if (hour > 6 && hour <= 12)
			{
				Console.WriteLine("早上好");
			}
			else if (hour > 12 && hour <= 18)
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

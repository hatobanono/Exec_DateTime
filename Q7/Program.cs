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
			string msg = string.Empty;

			if (hour > 6 && hour <= 12)
			{
				msg = "早上好";
			}
			else if (hour > 12 && hour <= 18)
			{
				msg = "下午好";
			}
			else
			{
				msg = "晚上好";
			}

			Console.WriteLine(msg);
		}
	}
}

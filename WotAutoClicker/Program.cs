using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace WotAutoClicker
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread.Sleep(3000);
			Clicker.Click();
		}
	}
}

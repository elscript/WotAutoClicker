using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace WotAutoClicker
{
	public class Clicker
	{
		private Clicker() { }

		public static void Click()
		{
			var targetLocation = ConfigurationReader.GetRolloutButtonLocation();
			WinApiInputWrapper.SendInput(targetLocation.X, targetLocation.Y);
		}
	}
}

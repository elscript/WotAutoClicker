using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WotAutoClicker
{
	public class ConfigurationReader
	{
		private ConfigurationReader() {}

		private static Point _buttonLocation = new Point();
		private static Point _windowPosition = new Point(0, 0);
		private static Point _windowSize = new Point();

		public static Point GetRolloutButtonLocation()
		{
			try
			{
				ParseConfig();
				CalculateButtonPosition();
			}
			catch (Exception e)
			{
				Trace.TraceError("EXCEPTION : {0}", e);
			}
			return _buttonLocation;
		}

		private static void ParseConfig()
		{
			string path = Environment.ExpandEnvironmentVariables("%Appdata%\\wargaming.net\\WorldOfTanks\\preferences.xml");

			root root = null;

			XmlSerializer serializer = new XmlSerializer(typeof(root));

			StreamReader reader = new StreamReader(path);
			root = (root)serializer.Deserialize(reader);
			reader.Close();

			bool windowed;
			if (Boolean.TryParse(root.devicePreferences.windowed, out windowed))
			{
				_windowSize.X = (int)root.devicePreferences.windowedWidth;
				_windowSize.Y = (int)root.devicePreferences.windowedHeight;
				_windowPosition.X = (int) root.devicePreferences.positionX;
				_windowPosition.Y = (int)root.devicePreferences.positionY;
			}
			else
			{
				_windowSize.X = (int)root.devicePreferences.fullscreenWidth;
				_windowSize.Y = (int)root.devicePreferences.fullscreenHeight;
			}
		}

		private static void CalculateButtonPosition()
		{
			_buttonLocation.X = _windowPosition.X + _windowSize.X/2;
			_buttonLocation.Y = _windowPosition.Y + _windowSize.Y/25;
		}
	}
}

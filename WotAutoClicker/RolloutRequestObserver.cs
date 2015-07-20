using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonInterfaces;

namespace WotAutoClicker
{
	/// <summary>
	/// Listener запросов
	/// </summary>
	public class RolloutRequestObserver : IListener
	{
		

		public RolloutRequestObserver(IClickerServer server)
		{
			server.Subscribe(this);
		}

		public void Subscibe()
		{
			throw new NotImplementedException();
		}

		public void Unsubscribe()
		{
			throw new NotImplementedException();
		}

		public EventHandler OnRequest()
		{
			throw new NotImplementedException();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CommonInterfaces
{
	public interface IListener
	{
		EventHandler OnRequest();
		void Subscibe();
		void Unsubscribe();
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CommonInterfaces
{
    public interface IClickerServer
    {
	    void Subscribe(IListener listener);
		void Unsubscribe(IListener listener);
    }
}

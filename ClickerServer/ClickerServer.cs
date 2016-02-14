using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonInterfaces;

namespace ClickerServer
{
	/// <summary>
	/// Сервер, запускающий игроков в бой по команде от главного по каналу.
	/// </summary>
	public class ClickerServer : IClickerServer
	{
		/// <summary>
		/// Уникальный экземляр
		/// </summary>
		private static ClickerServer _instance;

		///

		/// <summary>
		/// Приватный конструктор, т.к. используется шаблон "Singleton"
		/// </summary>
		private ClickerServer()
		{
		}

		/// <summary>
		/// Возвращает экземляр сервера
		/// </summary>
		/// <returns></returns>
		public static ClickerServer GetInstance()
		{
			return _instance ?? (_instance = new ClickerServer());
		}

		/// <summary>
		/// Запускает всех согласных в бой
		/// </summary>
		public void RollOutGuys()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Подписка Listener'а
		/// </summary>
		/// <param name="listener"></param>
		public void Subscribe(IListener listener)
		{
			
		}

		/// <summary>
		/// Отписывание Listener'а
		/// </summary>
		public void Unsubscribe(IListener listener)
		{
			
		}
	}
}

using System;

namespace FactoryMethod.Example
{
	/// <summary>
	/// Мессенджер Телеграма
	/// </summary>
	public class TelegramMessanger : MessangerBase
	{
		/// <summary>
		/// Мессенджер Телеграма
		/// </summary>
		/// <param name="name">Логин</param>
		/// <param name="password">Пароль</param>
		public TelegramMessanger(string name, string password) : base(name, password) { }

		/// <summary>
		/// Авторизация пользователя в Телеграме
		/// </summary>
		/// <returns>Успешность авторизации</returns>
		public override bool Authorize()
		{
			// TODO: обращение к API Телеграма для авторизации.
			Console.WriteLine($"Авторизация в Telegram пользователя с именем {UserName} и паролем {Password}");
			return true;
		}

		/// <summary>
		/// Создать сообщение для отправки в Телеграм
		/// </summary>
		/// <param name="text">Текст сообщения Телеграма</param>
		/// <param name="source">Отправитель</param>
		/// <param name="target">Получатель</param>
		/// <returns>Сообщение Телеграма</returns>
		public override IMessage CreateMessage(string text, string target)
		{
			var message = new TelegramMessage(text, UserName, target);
			return message;
		}
	}
}
using System;

namespace FactoryMethod.Example
{
	/// <summary>
	/// Мессенджер Инстаграма
	/// </summary>
	public class InstagramMessanger : MessangerBase
	{
		/// <summary>
		/// Мессенджер Инстаграма
		/// </summary>
		/// <param name="name">Логин</param>
		/// <param name="password">Пароль</param>
		public InstagramMessanger(string name, string password) : base(name, password) { }

		/// <summary>
		/// Авторизация пользователя в Инстаграме
		/// </summary>
		/// <returns>Успешность авторизации</returns>
		public override bool Authorize()
		{
			// TODO: обращение к API Инстаграма для авторизации.
			Console.WriteLine($"Авторизация в Instagram пользователя с именем {UserName} и паролем {Password}");
			return true;
		}

		/// <summary>
		/// Создать сообщение для отправки в Инстаграм
		/// </summary>
		/// <param name="text">Текст сообщения Инстаграма</param>
		/// <param name="source">Отправитель</param>
		/// <param name="target">Получатель</param>
		/// <returns>Сообщение Инстаграма</returns>
		public override IMessage CreateMessage(string text, string target)
		{
			var message = new InstagramMessage(text, UserName, target);
			return message;
		}
	}
}
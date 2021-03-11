namespace FactoryMethod.Example
{
	/// <summary>
	/// Базовый класс месседжера
	/// </summary>
	public abstract class MessangerBase : IMessager
	{
		/// <summary>
		/// Имя пользователя
		/// </summary>
		public string UserName { get; }

		/// <summary>
		/// Пароль
		/// </summary>
		public string Password { get; }

		/// <summary>
		/// Состояние соединения
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Создание экземпляра мессенджера и авторизация.
		/// </summary>
		/// <param name="userName">Имя пользователя</param>
		/// <param name="password">Пароль</param>
		public MessangerBase(string userName, string password)
		{
			// Не забываем проверять входные параметры перед авторизацией.
			if (!(string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace(password)))
			{
				UserName = userName;
				Password = password;
				Connected = Authorize();
			}
			else
			{
				Connected = false;
			}
		}

		/// <summary>
		/// Авторизоваться
		/// </summary>
		/// <returns> Успешность авторизации. </returns>
		public abstract bool Authorize();

		/// <summary>
		/// Создать сообщение
		/// </summary>
		/// <param name="text">Текст сообщения</param>
		/// <param name="source">Отправитель</param>
		/// <param name="target">Получатель</param>
		/// <returns>Сообщение</returns>
		public abstract IMessage CreateMessage(string text, string target);
	}
}

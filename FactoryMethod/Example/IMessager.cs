namespace FactoryMethod.Example
{
	/// <summary>
	/// Месседжер
	/// </summary>
	public interface IMessager
	{
		/// <summary>
		/// Имя пользователя
		/// </summary>
		string UserName { get; }

		/// <summary>
		/// Пароль
		/// </summary>
		string Password { get; }

		/// <summary>
		/// Состояние авторизации
		/// </summary>
		bool Connected { get; }

		/// <summary>
		/// Создать сообщение
		/// </summary>
		/// <param name="text">Текст сообщения</param>
		/// <param name="source">Отправитель</param>
		/// <param name="target">Получатель</param>
		/// <returns>Месседжер</returns>
		IMessage CreateMessage(string text, string target);

		/// <summary>
		/// Авторизоваться
		/// </summary>
		/// <returns>Состояние авторизации</returns>
		bool Authorize();
	}
}

namespace FactoryMethod.Example
{
	/// <summary>
	/// Базовый класс сообщения
	/// </summary>
	public abstract class MessageBase : IMessage
	{
		/// <summary>
		/// Текст сообщения
		/// </summary>
		public string Text { get; protected set; }

		/// <summary>
		/// Отправитель
		/// </summary>
		public string Source { get; }

		/// <summary>
		/// Получатель
		/// </summary>
		public string Target { get; }

		/// <summary>
		/// Создать сообщение
		/// </summary>
		/// <param name="text">Текст сообщения</param>
		/// <param name="source">Отправитель</param>
		/// <param name="target">Получатель</param>
		public MessageBase(string text, string source, string target)
		{
			Text = text;
			Source = source;
			Target = target;
		}

		/// <summary>
		/// Отправить сообщение.
		/// </summary>
		public abstract void Send();
	}
}

namespace FactoryMethod.Example
{
	/// <summary>
	/// Сообщение
	/// </summary>
	public interface IMessage
	{
		/// <summary>
		/// Текст сообщения
		/// </summary>
		string Text { get; }

		/// <summary>
		/// Отправитель соощения
		/// </summary>
		string Source { get; }

		/// <summary>
		/// Получатель сообщения
		/// </summary>
		string Target { get; }

		/// <summary>
		/// Отправить сообщение
		/// </summary>
		void Send();
	}
}

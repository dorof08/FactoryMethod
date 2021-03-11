using System;

namespace FactoryMethod.Example
{
	/// <summary>
	/// Сообщение Телеграма
	/// </summary>
	public class TelegramMessage : MessageBase
	{
		/// <summary>
		/// Cообщение Телеграма
		/// </summary>
		/// <param name="text">Текст сообщения</param>
		/// <param name="source">Отправитель</param>
		/// <param name="target">Получатель</param>
		public TelegramMessage(string text, string source, string target) : base(text, source, target) { }

		/// <summary>
		/// Отправить сообщение в Телеграм
		/// </summary>
		public override void Send()
		{
			// TODO: Обращение к API Телеграма для отправки сообщения.
			Console.WriteLine($"Telegram: сообщение от \"{Source}\" для \"{Target}\": \"{Text}\"");
		}
	}
}
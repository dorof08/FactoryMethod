using System;

namespace FactoryMethod.Example
{
	/// <summary>
	/// Сообщение Инстаграма
	/// </summary>
	public class InstagramMessage : MessageBase
	{
		/// <summary>
		/// Cообщение Инстаграма
		/// </summary>
		/// <param name="text">Текст сообщения</param>
		/// <param name="source">Отправитель</param>
		/// <param name="target">Получатель</param>
		public InstagramMessage(string text, string source, string target) : base(text, source, target) { }

		/// <summary>
		/// Отправить сообщение в Инстаграм
		/// </summary>
		public override void Send()
		{
			// TODO: Обращение к API Инстаграма для отправки сообщения.
			Console.WriteLine($"Instagram: сообщение от \"{Source}\" для \"{Target}\": \"{Text}\"");
		}
	}
}
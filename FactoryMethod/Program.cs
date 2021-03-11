using FactoryMethod.ClassicVariation;
using FactoryMethod.Example;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			// Пример
			var telegram = new TelegramMessanger("Иван Телеграм", "Пароль Иван Телеграм");
			var telegramMessage = telegram.CreateMessage("Текст телеграма", "Петр Телеграм");

			var instagram = new InstagramMessanger("Иван Инстаграм", "Пароль Иван Инстаграм");
			var instagramMessage = instagram.CreateMessage("Текст инстаграма", "Петр Инстаграм");

			telegramMessage.Send();
			instagramMessage.Send();

			// Классиеская версия
			var creator = new ConcreteCreator();
			var product = creator.CreateProduct();
			product.DoWork();
		}
	}
}

using System;

namespace FactoryMethod.ClassicVariation
{
	/// <summary>
	/// Продукт (Конкретный продукт)
	/// </summary>
	class ConcreteProduct : IProduct
	{
		public string Field { get; set; }

		public void DoWork()
		{
			Console.WriteLine("Продукт работает");
		}
	}
}

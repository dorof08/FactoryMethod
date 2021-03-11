namespace FactoryMethod.ClassicVariation
{
	/// <summary>
	/// Продукт (Обобщенный Продукт)
	/// </summary>
	public interface IProduct
	{
		string Field { get; set; }
		void DoWork();
	}
}

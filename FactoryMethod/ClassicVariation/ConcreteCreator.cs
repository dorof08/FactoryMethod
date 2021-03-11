namespace FactoryMethod.ClassicVariation
{
	public class ConcreteCreator : Creator
	{
		public override IProduct CreateProduct()
		{
			return new ConcreteProduct();
		}
	}
}

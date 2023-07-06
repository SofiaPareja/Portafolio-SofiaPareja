using System;
namespace PatronesCreacionales
{

    public interface IProduct
    {
        string Operation();
    }

    public class FactoryMethod
	{
		public FactoryMethod()
		{
		}

	
	}

	abstract class Creator {
		public abstract IProduct FactoryMethod();

		public string SomeOperation() {
			var producto = FactoryMethod();
			var result = "Creator: The same creator's code has just worked with "
                + producto.Operation();
			return result;
        }
	}

    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }

    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

}


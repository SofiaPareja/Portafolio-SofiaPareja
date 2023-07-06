using System;
namespace PatronesCreacionales
{
	public class Pizza
	{

		private string dough = "";
		private string sauce = "";
		private string topping = "";

		public Pizza()
		{
		}

		public void setDough(string dough) {
			this.dough = dough;
		}

        public void setSauce(string sauce)
        {
            this.sauce = sauce;
        }

        public void setTopping(string topping)
        {
            this.topping = topping;
        }
    }

	public interface IPizzaBuilder {

		void buildDough();
		void buildSauce();
		void buildTopping();
        void reset();
        Pizza getPizza();
        
	}


    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void buildDough()
        {
            this.pizza.setDough("cross");
        }

        public void buildSauce()
        {
            this.pizza.setSauce("mild");
        }

        public void buildTopping()
        {
            this.pizza.setTopping("ham+pineapple");
        }

        public Pizza getPizza() {
            return this.pizza;
        }

        public void reset()
        {
            this.pizza = new Pizza();
        }
    }

    public class SpicyPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void buildDough()
        {
            this.pizza.setDough("pan baked");
        }

        public void buildSauce()
        {
            this.pizza.setSauce("hot");
        }

        public void buildTopping()
        {
            this.pizza.setTopping("pepperoni+salami");
        }

        public Pizza getPizza()
        {
            return this.pizza;
        }

        public void reset()
        {
            this.pizza = new Pizza();
        }
    }

    public class Waiter {

        private IPizzaBuilder pizzaBuilder;

        public void setPizzaBuilder(IPizzaBuilder pb) {
            this.pizzaBuilder = pb;
        }

        public Pizza getPizza() {
            return pizzaBuilder.getPizza();
        }

        public void constructPizza() {

            pizzaBuilder.buildDough();
            pizzaBuilder.buildSauce();
            pizzaBuilder.buildTopping();
        }
    }

    
}


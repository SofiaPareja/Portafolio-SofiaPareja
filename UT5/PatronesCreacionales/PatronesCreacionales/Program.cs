using System.IO;
using PatronesCreacionales;

class Program
{
    static void Main(string[] args)
    {
        IPizzaBuilder hawaiian = new HawaiianPizzaBuilder();
        IPizzaBuilder spicy = new SpicyPizzaBuilder();

        Waiter mozo = new Waiter();

        mozo.setPizzaBuilder(hawaiian);
        mozo.constructPizza();
        Pizza pizza = mozo.getPizza();
    }
}


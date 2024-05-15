using Builder;

class Program
{
    static void Main(string[] args)
    {
        IPizzaBuilder margheritaPizzaBuilder = new MargheritaPizzaBuilder();
        PizzaDirector director = new PizzaDirector(margheritaPizzaBuilder);

        director.ConstructPizza();
        Pizza margheritaPizza = director.GetPizza();
        Console.WriteLine(margheritaPizza);

        IPizzaBuilder pepperoniPizzaBuilder = new PepperoniPizzaBuilder();
        director = new PizzaDirector(pepperoniPizzaBuilder);

        director.ConstructPizza();
        Pizza pepperoniPizza = director.GetPizza();
        Console.WriteLine(pepperoniPizza);
    }
}

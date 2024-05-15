using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PizzaDirector
    {
        private IPizzaBuilder _pizzaBuilder;

        public PizzaDirector(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void ConstructPizza()
        {
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildCheese();
            _pizzaBuilder.BuildToppings();
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }
    }

}

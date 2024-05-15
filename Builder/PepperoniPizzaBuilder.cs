using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PepperoniPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough()
        {
            _pizza.Dough = "Thick crust";
        }

        public void BuildSauce()
        {
            _pizza.Sauce = "Tomato sauce";
        }

        public void BuildCheese()
        {
            _pizza.Cheese = "Mozzarella cheese";
        }

        public void BuildToppings()
        {
            _pizza.Toppings = "Pepperoni slices";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }

}

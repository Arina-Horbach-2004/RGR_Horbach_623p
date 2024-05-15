using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MargheritaPizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void BuildDough()
        {
            _pizza.Dough = "Thin crust";
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
            _pizza.Toppings = "Basil leaves";
        }

        public Pizza GetPizza()
        {
            return _pizza;
        }
    }

}

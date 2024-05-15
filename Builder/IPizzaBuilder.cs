using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IPizzaBuilder
    {
        void BuildDough();
        void BuildSauce();
        void BuildCheese();
        void BuildToppings();
        Pizza GetPizza();
    }

}

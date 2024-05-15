using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public string Toppings { get; set; }

        public override string ToString()
        {
            return $"Pizza with {Dough}, {Sauce}, {Cheese}, and {Toppings}";
        }
    }

}

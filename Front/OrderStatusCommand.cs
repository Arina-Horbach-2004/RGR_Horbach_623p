using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front
{
    public class OrderStatusCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Displaying Order Status");
        }
    }
}

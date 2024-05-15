using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front
{
    public class CreateOrderCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Creating Order");
        }
    }
}

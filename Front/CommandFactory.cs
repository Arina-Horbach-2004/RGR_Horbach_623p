using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front
{
    public static class CommandFactory
    {
        public static ICommand GetCommand(string request)
        {
            switch (request.ToLower())
            {
                case "menu":
                    return new MenuCommand();
                case "createorder":
                    return new CreateOrderCommand();
                case "orderstatus":
                    return new OrderStatusCommand();
                default:
                    throw new Exception("Invalid command");
            }
        }
    }

}

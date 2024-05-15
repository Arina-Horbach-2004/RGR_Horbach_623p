using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front
{
    public class FrontController
    {
        public void DispatchRequest(string request)
        {
            try
            {
                ICommand command = CommandFactory.GetCommand(request);
                command.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}

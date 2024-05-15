using System;
using System.Threading.Tasks;


namespace Asynchronous_method_invocation
{
    public class OrderProcessor
    {
        public async Task<bool> CheckInventoryAsync(string productId)
        {
            // Симуляція перевірки наявності товару
            await Task.Delay(1000); // симуляція затримки
            Console.WriteLine($"Inventory check completed for product {productId}.");
            return true; // припускаємо, що товар є в наявності
        }

        public async Task<bool> ProcessPaymentAsync(string paymentDetails)
        {
            // Симуляція обробки платежу
            await Task.Delay(1000); // симуляція затримки
            Console.WriteLine($"Payment processed for {paymentDetails}.");
            return true; // припускаємо, що платіж успішний
        }

        public async Task SendConfirmationAsync(string orderId)
        {
            // Симуляція відправки підтвердження замовлення
            await Task.Delay(500); // симуляція затримки
            Console.WriteLine($"Order confirmation sent for order {orderId}.");
        }
    }
}
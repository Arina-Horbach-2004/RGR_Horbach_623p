using Asynchronous_method_invocation;
using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        OrderProcessor processor = new OrderProcessor();

        string productId = "12345";
        string paymentDetails = "CreditCard";
        string orderId = "Order123";

        // Виклик асинхронних методів для обробки замовлення
        Task<bool> inventoryTask = processor.CheckInventoryAsync(productId);
        Task<bool> paymentTask = processor.ProcessPaymentAsync(paymentDetails);
        Task confirmationTask = processor.SendConfirmationAsync(orderId);

        // Очікування завершення всіх асинхронних завдань
        bool[] results = await Task.WhenAll(inventoryTask, paymentTask);
        await confirmationTask;

        // Обробка результатів
        if (results[0] && results[1])
        {
            Console.WriteLine("Order processed successfully.");
        }
        else
        {
            Console.WriteLine("Order processing failed.");
        }
    }
}

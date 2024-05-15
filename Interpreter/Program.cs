using Interpreter;

public class Program
{
    public static void Main(string[] args)
    {
        // Створення термінальних виразів
        Expression distance = new DistanceExpression(15); // 15 км
        Expression rate = new RatePerKmExpression(1.5); // 1.5 долара за км

        // Створення нетермінальних виразів
        Expression baseFare = new MultiplyExpression(distance, rate);
        Expression serviceCharge = new RatePerKmExpression(2.0); // 2 долари сервісний збір
        Expression totalFare = new AddExpression(baseFare, serviceCharge);

        // Контекст (в цьому прикладі не використовується, але може зберігати додаткові параметри)
        var context = new Dictionary<string, double>();

        // Інтерпретація виразів
        double fare = totalFare.Interpret(context);
        Console.WriteLine($"Total fare for the trip is {fare} dollars");
    }
}



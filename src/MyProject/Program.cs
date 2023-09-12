using Serilog;

namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        // Setup the logger.
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        try
        {
            Console.WriteLine("Enter an additive number:");
            int additiveNumber = Convert.ToInt32(Console.ReadLine());
            Adder adder = new(additiveNumber);
            Console.WriteLine("Enter a number to add to:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = adder.Add(number);
            Console.WriteLine($"The sum is {sum}");
        }
        catch (Exception exception)
        {
            Log.Fatal(exception, "encountered an unhandled exception");
        }
    }
}

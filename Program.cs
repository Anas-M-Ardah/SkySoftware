using System.Globalization;
using ObjectHW1;
using ConsoleColor = ObjectHW1.ConsoleColor;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to my calculator");
        Calculator calculator = new Calculator();
        TakeInput(calculator, "x");
        TakeInput(calculator, "y");
        calculator.DoCalculations();
    }

    public static void TakeInput(Calculator calculator, string variable)
    {
        decimal value;
        ConsoleColor color = new ConsoleColor();

        Console.Write($"Please enter the value of {variable}: ");

        while (true)
        {   
            color.ResetColor();
            string userInput = Console.ReadLine();
            if (decimal.TryParse(userInput, out value))
            {
                Console.WriteLine($"You entered a valid number: {value}");
                if (variable.ToLower() == "x")
                {
                    color.SetConsoleColor("green");   
                    calculator.setX(value);
                    Console.WriteLine($"{variable}: {calculator.getX()}");
                }
                else if (variable.ToLower() == "y")
                {
                    color.SetConsoleColor("green");
                    calculator.setY(value);
                    Console.WriteLine($"{variable}: {calculator.getY()}");
                }
                else
                {
                    color.SetConsoleColor("red");
                    Console.WriteLine("Invalid variable");
                }
                break;
            }
            else
            {
                color.SetConsoleColor("Red");
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        color.ResetColor();
    }
}
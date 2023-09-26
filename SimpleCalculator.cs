using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("Geben Sie zwei Zahlen ein");

        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Wählen Sie einen Vorgang aus (+, -, *, /):");
        char operation = Console.ReadKey().KeyChar;

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid Vorgang");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}

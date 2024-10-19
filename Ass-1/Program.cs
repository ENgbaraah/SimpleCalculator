using System;
class SimpleCalculator
{
     static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Choose an operation (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

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
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operation");
                return;
        }

        Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
    }
}

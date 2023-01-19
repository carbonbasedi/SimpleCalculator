using System;

namespace SwitchCase
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("--- Enter first operand ---");
            double num1 = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("--- Enter second operand ---");
            double num2 = Convert.ToDouble(Console.ReadLine());


        Check: Console.WriteLine("--- Enter operation type ---");
            var operation = (Console.ReadLine());

            {
                switch (operation)
                {

                    case "+":
                        Console.WriteLine($"Result is {num1 + num2}");
                        break;
                    case "-":
                        Console.WriteLine($"Result is {num1 - num2}");
                        break;
                    case "*":
                        Console.WriteLine($"Result is {num1 * num2}");
                        break;
                    case "/":
                        Console.WriteLine($"Result is {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Invalid operator input try again");
                        goto Check;

                }
            }
        }
    }
}
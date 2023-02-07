using System;

decimal num1 = 0;
decimal num2 = 0;
string? operation;
string? operationName;
decimal result = 0;
string? repeat;


do
{

Console.WriteLine("Console Calculator in C#");
Console.WriteLine("------------------------\n");

Console.WriteLine("Type first number and then press enter");
num1 = Convert.ToDecimal(Console.ReadLine()?.Replace('.',',')) ;

Console.WriteLine("Type another number and press enter");
num2 = Convert.ToDecimal(Console.ReadLine()?.Replace('.', ','));

Console.WriteLine("Select math operation ffrom below list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Substract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.WriteLine("Your option?:");

operation = Console.ReadLine()?.ToLower();

switch (operation)
{
    case "a":
        // Add
        operationName = "+";
        result = num1 + num2;
        break;

    case "s":
        operationName = "-";
        result = num1 - num2;
        break;

    case "m":
        operationName = "*";
        result = num1 * num2;
        break;

    case "d":
            while(num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor:");
                num2 = Convert.ToDecimal(Console.ReadLine()?.Replace('.', ','));
            }
        operationName= "/";
        result = num1 / num2;
        break;

    default:
        operationName = "_";
        Console.WriteLine("Unknown operation.");
        break;
}


Console.WriteLine($"The result of {num1} {operationName} {num2} is: {result:N3}");

Console.WriteLine("New operation? (y/N):");
repeat = Console.ReadLine()?.ToLower();

if (repeat != "n")
{
        Console.Clear();
}


} while(repeat != "n");


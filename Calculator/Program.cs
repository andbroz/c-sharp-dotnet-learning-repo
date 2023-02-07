using System;
using MyCalc;



bool endApp = false;


while (!endApp)
{
    Console.Clear();
    Console.WriteLine("Console Calculator in C#");
    Console.WriteLine("------------------------\n");
    string? numInput1 = "";
    string? numInput2 = "";
    double result = 0;
    double cleanNum1 = 0;
    double cleanNum2 = 0;

    string? operation;
    string? operationName;

    // input 1
    Console.WriteLine("Type first number and then press enter");
    numInput1 = Console.ReadLine();

    while (!double.TryParse(numInput1, out cleanNum1))
    {
        Console.Write("This is not valid input. Please enter an decimal value: ");
        numInput1 = Console.ReadLine();
    }

    // input 2
    Console.WriteLine("Type another number and press enter");
    numInput2 = Console.ReadLine();

    while (!double.TryParse(numInput2, out cleanNum2))
    {
        Console.Write("This is not valid input. Please enter an decimal value: ");
        numInput2 = Console.ReadLine();
    }

    // operation
    Console.WriteLine("Select math operation ffrom below list:");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Substract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.WriteLine("Your option?:");

    operation = Console.ReadLine()?.ToLower();


    try
    {
        if(operation is null)
        {
            throw new AggregateException("invalid math operation");
        }
        result = Calculator.DoOperation(cleanNum1, cleanNum2, operation, out operationName);

        if (double.IsNaN(result))
        {
            Console.WriteLine("This operation will result in a mathematical error.\n");
        }
        else
        {
            Console.WriteLine($"The result of {cleanNum1} {operationName} {cleanNum2} is: {result:N3}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + ex.Message);
    }

    Console.WriteLine("------------------------\n");

    Console.WriteLine("New operation? (y/N):");
    endApp = Console.ReadLine()?.ToLower() != "y";

}


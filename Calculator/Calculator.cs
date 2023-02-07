using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc
{
    public static class Calculator
    {

        public static double DoOperation(double num1, double num2, string operation, out string? operationName)
        {
            double result = double.NaN;
            operationName = null;

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
                    if (num2 != 0)
                    {
                        operationName = "/";
                        result = num1 / num2;
                    }
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}

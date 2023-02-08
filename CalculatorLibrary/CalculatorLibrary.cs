using System.Diagnostics;
using Newtonsoft.Json;

namespace CalculatorLibrary
{
    public  class Calculator
    {

        JsonWriter writer;

        public Calculator()
        {
            //StreamWriter logFile = File.CreateText("calculator.log");
            //Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            //Trace.AutoFlush = true;
            //Trace.WriteLine("Starting Calculator Log");
            //Trace.WriteLine($"Started {DateTime.Now}");

            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }

        public  double DoOperation(double num1, double num2, string operation, out string? operationName)
        {
            double result = double.NaN;
            operationName = null;

            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(num1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(num2);
            writer.WritePropertyName("Operation");

            switch (operation)
            {
                case "a":
                    // Add
                    operationName = "+";
                    result = num1 + num2;
                    // Trace.WriteLine(string.Format("{0} + {1} = {2}", num1, num2, result));
                    writer.WriteValue("Add");
                    break;

                case "s":
                    // Substract
                    operationName = "-";
                    result = num1 - num2;
                    //Trace.WriteLine(string.Format("{0} - {1} = {2}", num1, num2, result));
                    writer.WriteValue("Subtract");
                    break;

                case "m":
                    // Multiply
                    operationName = "*";
                    result = num1 * num2;
                    //Trace.WriteLine(string.Format("{0} * {1} = {2}", num1, num2, result));
                    writer.WriteValue("Multiply");
                    break;

                case "d":
                    // Divide
                    if (num2 != 0)
                    {
                        operationName = "/";
                        result = num1 / num2;
                        //Trace.WriteLine(string.Format("{0} / {1} = {2}", num1, num2, result));
                    }
                    writer.WriteValue("Divide");
                    break;

                default:
                    break;
            }

            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();

            return result;
        }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}
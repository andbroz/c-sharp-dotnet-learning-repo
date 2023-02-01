using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Error.Handling
{
    public static class ExceptionsDemo
    {
        private static bool s_end = false;

        public static void DoException(string? inputText)
        {

            do
            {
                try
                {
                    Console.WriteLine("Type a key: ");
                    var input = Console.ReadKey();
                    Console.WriteLine();
                    Console.Write("Your input was:");

                    Console.WriteLine(input.KeyChar);

                    if (input.KeyChar.Equals('E'))
                    {
                        Console.WriteLine("Ups something went wrong.");
                        throw new ArgumentException($"{nameof(input.Key)} wrong key pressed");
                    }
                    if (input.KeyChar.Equals('n'))
                    {
                        Console.WriteLine("Ups something went wrong.");
                        throw new NotImplementedException("error here");
                    }
                    if (input.KeyChar.Equals('k'))
                    {
                        Console.WriteLine("Ups something went wrong.");
                        throw new InvalidOperationException("error here");
                    }
                    if (input.KeyChar.Equals('o'))
                    {
                        Console.WriteLine("Ups something went wrong.");
                        throw new ArgumentOutOfRangeException(nameof(inputText), "Input text should not be empty");
                    }

                    if (input.KeyChar.Equals('q'))
                    {
                        s_end = true;
                        Console.WriteLine("Exiting program");
                    }



                }
                // implement catch statement from most specific exception type
                // to the least specific exception type at the bottom
                catch (ArgumentException error)
                {
                    Console.WriteLine(error.ToString());
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine(e.ToString());
                }
                // the least specific exception
                catch (Exception e)
                {
                    // handle all other exceptions
                    Console.WriteLine(e.ToString());
                }
                // after all exceptions we can implement signle finally block
                finally
                {
                    Console.WriteLine("Finally all is good. We made it to the end.");
                }

            } while (!s_end);

        }

    }
}

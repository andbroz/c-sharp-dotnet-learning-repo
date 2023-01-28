using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.StringManipulation
{
    internal class StringManipulation
    {
        public string LoremStringOne = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

        public static void StringConversion()
        {
            Console.WriteLine("\n\t 1. String Conversion\n");

            string testString = "ThIs iS tHe FBI cAllIng!";

            // current operating system culture
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            // custom culture
            TextInfo englishTextInfo = new CultureInfo("en-US", false).TextInfo;

            Console.WriteLine($"testString: {testString}");

            string lower = testString.ToLower();
            Console.WriteLine($".ToLower() method result: {lower}");

            string upper = testString.ToUpper();
            Console.WriteLine($".ToUpper() method result: {upper}");

            string titleCase = currentTextInfo.ToTitleCase(testString);
            string titleCaseEnglish = englishTextInfo.ToTitleCase(testString);
            Console.WriteLine($"currentTextInfo.ToTitleCase() method result: {titleCase}");
            Console.WriteLine($"englishTextInfo.ToTitleCase() method result: {titleCaseEnglish}");


        }

        public static void StringAsArray()
        {
            string testString = "Andrzej";

            Console.WriteLine("\n\t 2. String As Array\n");

            for (int i = 0; i < testString.Length; i++)
            {
                Console.Write($"[{i}]: ");
                Console.Write(testString[i]);
                Console.Write("\t");
            }
            Console.WriteLine("");
        }

        public static void EscapeString()
        {
            Console.WriteLine("\n\t 3. Escape string\n");


            var results = "This is my \"test\"solution. To escape quotes use backslash before it \\\"";
            Console.WriteLine(results);

            // Escaping backslash in path -> use double backslash \\
            var testPath = "C:\\Demo\\Test.txt";
            Console.WriteLine(testPath);

            // string literal is created by adding @ beginning of string
            var testPathLiteral = @"C:\Demo\Test.txt";
            Console.WriteLine(testPathLiteral);
        }

        public static void AppendingStrings()
        {
            Console.WriteLine("\n\t 4. Appending strings\n");

            string firstName = "Janko";
            string lastName = "Muzykant";

            string results;


            // appending strings by + operator
            results = firstName + ", my name is " + firstName + " " + lastName;
            Console.WriteLine(results);

            // using string.Format() 
            results = string.Format("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(results);


            // string interpolation
            results = $"{firstName}, my name is {firstName} {lastName}";
            Console.WriteLine(results);


        }

        public static void InterpolationAndLiteral()
        {
            Console.WriteLine("\n\t 5. Interpolation and Literal\n");

            string testString = "Michael Jordan";
            // I want to fill <name> with a variable => string results = $@"C:\demo\<name>\Test.txt";
            string results = $@"C:\demo\{testString}\Test.txt";

            Console.WriteLine(results);
            
            // put quotes around Test in literal string -> possible when $@ interpolated literal string
            results = $@"C:\demo\{testString}\{"\""}Test{"\""}.txt";

            Console.WriteLine(results);


        }

        // https://www.youtube.com/watch?v=ioi__WRETk4 28:16
    }
}

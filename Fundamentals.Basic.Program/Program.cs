using People;
using System;


namespace Fundamentals
{

    class Program
    {
        static void Main()
        {
            Person adam = new Person("adam",44);

            Console.WriteLine(adam);

        }


    }

   
}

namespace People
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }
    }
}

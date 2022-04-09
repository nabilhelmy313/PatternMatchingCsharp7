using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***************first example****************/
            int? notNullNumber = 10;
            if (notNullNumber is int x)
                WriteLine($"the value is number {x}");
            else
                WriteLine($"the value Not Found");
            //***************second example****************/

            Person person = null;
            if (person is not null)
                WriteLine($"Has value is { person.Name}");
            else if (person is null)
                WriteLine("Has No Person");


            PrintData(person);
        }
        private static void PrintData(object obj)
        {
            switch (obj)
            {
                case 0:
                case 5:
                case true:
                    WriteLine($"you passed {obj}");
                    break;
                case int number:
                    WriteLine($"you passed a numeric value");
                    break;
                case bool b:
                    WriteLine($"you passed a boolean value");
                    break;
                default:
                    WriteLine($"Invalid data");
                    break;
            }
        }
    }
}

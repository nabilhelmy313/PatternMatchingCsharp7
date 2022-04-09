using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternMatching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***************first example****************/
            int? notNullNumber = 10;
            if (notNullNumber is int x)
                Console.WriteLine($"the value is number {x}");
            else
                Console.WriteLine($"the value Not Found");
            //***************second example****************/

            Person person = null;
            if (person is not null)
                Console.WriteLine($"Has value is { person.Name}");
            else if (person is null)
                Console.WriteLine("Has No Person");

        }
    }
}

using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        var names = new List<string> {"Alex", "Anna", "Felipe"};
    
            names.Add("Maria");
            names.Add("Tony");
            names.Remove("Alex");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
                Console.WriteLine($"Their name is {names[0]}");
                Console.WriteLine($"I added {names[2]} and {names[3]} to the list!");
                Console.WriteLine($"There are {names.Count} names in the list");
            }
        }
    }
}

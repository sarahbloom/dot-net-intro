using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
        var names = new List<string> {"Alex", "Anna", "Felipe"};
        foreach (var name in names)
            {
            Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {

        static void Main(string[] args){
            WorkingWithStrings();
        }
        static void WorkingWithStrings()
        {
        var names = new List<string> {"Alex", "Anna", "Felipe"};
    
            names.Add("Maria");
            names.Add("Tony");
            names.Remove("Alex");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"Their name is {names[0]}");
            Console.WriteLine($"I added {names[2]} and {names[3]} to the list!");
            Console.WriteLine($"There are {names.Count} names in the list");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");

            }
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}

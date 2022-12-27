using System;
using System.Collections.Generic;

namespace demoApp
{
    class Program
    {
        static void Main1(string[] args)
        {
            var names = new List<string> { "New friend","Scott","Kendra" };
            names.Add("Maria");
            names.Add("Bill");

            names.Sort();
            var index = names.IndexOf("Scott");
            foreach(String name in names)
            {
                Console.WriteLine($"Hello {name} your index  is {names.IndexOf(name)}");
            }
        }
    }
}

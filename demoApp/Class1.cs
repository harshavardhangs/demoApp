using System;
using System.Collections.Generic;
using System.Text;

namespace demoApp
{
    class Class1
    {
        static void Main(string[] args)
        {
            // declaring list
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20) 
            {
                //selecting last two numbers in list
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous1 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                //adding the sum of last two numbers in list 
                fibonacciNumbers.Add(previous + previous1);
            }

            //printing the items in the list
            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}

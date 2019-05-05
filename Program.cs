using System;
using System.Collections.Generic;

namespace ConsoleApplicationdemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Index start = 3;  // Get the 4th element from the beginning
            Index end = ^3;   // Get the 3rd element from the end

            string[] numbers = { "Zero", "One", "Two", "Three", "Four", "Five", "Six" };

            Console.WriteLine($"{numbers[start]}, {numbers[end]}"); // "Three , Four"


            var range = numbers[1..^2];

            foreach (var item in range)
            {
                Console.WriteLine(item);
            }
        }
    }
}


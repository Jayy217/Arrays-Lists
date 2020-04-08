//I couldn't quite understand why I needed to do this..? (adding System.Collections.Generic to 'using' for me to use lists)
using System;
using System.Collections.Generic;

namespace lists._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            System.Console.WriteLine("Please enter 5 numbers");

            for (int i = 0; i < 5; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            System.Console.WriteLine("One more number");

            int input = int.Parse(Console.ReadLine());

            if (numbers.Contains(input))
            {
                System.Console.WriteLine("This number exists in the list");
            }

            else
            {
                System.Console.WriteLine("This number does not exist in the list");
            }
        }
    }
}

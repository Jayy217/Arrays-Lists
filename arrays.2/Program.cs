using System;

namespace arrays._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {34,5,67,1,99,34,44,78,34,0};
            int total = 0;

            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }

            System.Console.WriteLine("The total of all values is " + total);
        }
    }
}

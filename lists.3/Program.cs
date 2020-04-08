using System;
using System.Collections.Generic;

namespace lists._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            string input = "i";

            while (input != "stop")
            {
                input = Console.ReadLine();
                words.Add(input);
            }

            System.Console.WriteLine("----------------");
            
            for (int i = words.Count - 1; i >= 0; i--)
            {
                System.Console.WriteLine(words[i]);
            }
        }
    }
}

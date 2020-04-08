using System;

namespace arrays._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string [5];
            int i = 0;

            System.Console.WriteLine("Please enter 5 names.");

            while (i < names.Length)
            {
                names[i] = Console.ReadLine ();
                i++;
            }
            i = 0;
            while (i < names.Length)
            {
                System.Console.WriteLine("Hello " + names[i]);
                i++;
            }

        }
    }
}

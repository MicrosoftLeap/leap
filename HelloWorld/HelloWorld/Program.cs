using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            // confict changes
            Console.WriteLine("conflicts...");
            Console.ReadKey();

            // modified
        }
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi {0}", name);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World To All!");//this is a new comment

            Console.WriteLine();//we have a conflict

            Console.WriteLine(); //new comment to create merge conflict 


            Console.WriteLine("Press any key to exit..."); //trying to push now 
            Console.ReadKey();  //changing to update pull request 
        }
    }
}

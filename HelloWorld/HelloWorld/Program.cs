using System;

namespace HelloWorld
{
    class Program
    {
        /*LeetCode Challenge Solution, Reverse integer in place, to include Negative Integers*/
        public int Reverse(int x)
        {

            String reversed = "";

            bool isNegative = false;

            if (x < 0)
            {
                x = Math.Abs(x);
                isNegative = true;
            }

            String toreverse = x.ToString();
            int counter = 0;
            while ((counter <= toreverse.Length) && (x > 0))
            {
                int remainder = x % 10;
                reversed += remainder.ToString();
                x /= 10;

                counter++;
            }

            if (isNegative == true)
            {
                //make number negative
                return Int32.Parse(reversed) * -1;
            }

            return Int32.Parse(reversed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            var p = new Program();
            int x = p.Reverse(-12345);
            Console.Write(x);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

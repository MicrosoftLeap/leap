using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // hello world

            Console.WriteLine("Hello World!");
            Console.ReadLine();


            // comments 

            //1. this is a Single line Comment

            /*
             * 2. multiple line comment
             * 
             * 
             */

            /// <summary>
            ///   3.  XML documentation comments 
            ///     
            /// </summary>



            // Variables 

            //1. 
            bool thisBool;
            int thisInt;
            double thisDouble;
            char thisChar;
            string thisString;
            //2. 
            thisBool = false;
            thisInt = 3;
            thisDouble = 3.3;
            thisChar = 'k';
            thisString = "Karen";

            //3.
            Console.WriteLine(thisBool);
            Console.WriteLine(thisInt);
            Console.WriteLine(thisDouble);
            Console.WriteLine(thisChar);
            Console.WriteLine(thisString);


            //Min and Max 

            //1.
            int maxInt = int.MaxValue;
            Console.WriteLine(maxInt);
            //2.
            maxInt += 1;
            Console.WriteLine(maxInt);
            Console.ReadLine();
            //3. when incrementing the maxInt it causes the int to start from the min 


            //Implicit type

            //1. 
            var implicitBool = false;
            var implicitInt = 3;
            var implicitDouble = 33.33;
            var implicitChar = 'K';
            var implicitString = "Karen";
            Console.WriteLine(implicitBool);
            Console.WriteLine(implicitInt);
            Console.WriteLine(implicitDouble);
            Console.WriteLine(implicitChar);
            Console.WriteLine(implicitString);



            //Operators 

            // Assignment and increment and decrement
            //1. 
            int x = 3;
            int y = 5;
            //2.
            int z1 = x++;
            //3.
            int z2 = ++y;
            //4.
            Console.WriteLine("{0},{1},{2},{3}", x, y, z1, z2);
            // z1 is using the post-fix operator and hold the value before it was incremented
            // z2 is using the prefix operator and holds the value after it was incremented 

            //Math 
            //1.
            int x1 = 3; int y1 = 7; int z = 11;
            //2.
            int a = x1 + y1; int b = x1 * z; int c = z / x1;
            //3.
            bool isEven = (x1 % 2 == 0);
            //4.
            bool isNotDivisibleByThree = (y1 % 3 != 0);
            //5.
            double roundedToThreePlaces = Math.Round(33.7833, 3);

            //Type Conversion 
            double A = (double)x1;
            double B = (double)y1;
            double C = (double)z;

            x = (int)A;
            y = (int)B;
            z = (int)C;


            //Strings 
            // Escapes and literals 
            //1.
            string stringWithEscape = "hello I \"hope\"this works";
            Console.WriteLine(stringWithEscape);
            string anotherString = "hello my name is Karen";

            //concatenate 
            Console.WriteLine(stringWithEscape + "I'm new to c#");
            //length 
            Console.WriteLine(anotherString + ":" + anotherString.Length);

            //indexing
            //1. 
            string oddnumberedString = "Karen";
            //2. 
            Console.WriteLine(oddnumberedString[0] + oddnumberedString.Substring(oddnumberedString.Length / 2, 1) + oddnumberedString.Substring(oddnumberedString.Length));
            oddnumberedString = oddnumberedString.Remove(0, 1);
            //3.
            Console.WriteLine(oddnumberedString);
            oddnumberedString = oddnumberedString.Remove(oddnumberedString.Length - 1, 1);
            Console.WriteLine(oddnumberedString);

            // searching 
            //1.
            String X = "abced";
            char Y = 'b';
            //2.
            int find(char character, string within)
            {
                return within.IndexOf(character);
            }
            //3.
            bool isThis(char character, string within)
            {
                return find(character, within) != -1;
            }
            //4. 
            string fakeFilePath = @"c:\\user\project\helloWorldr.txt";


            //Splitting 

            string stringWithManySpaces = "hello   how   are you?";
            string[] seperatedBySpaces = stringWithManySpaces.Split(" ");

            //formatting 


        }
    }
}

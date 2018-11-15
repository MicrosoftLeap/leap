using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = ReverseString("hello");
            Console.WriteLine(word);

        }

        static string ReverseString(string oldString)
        {
            StringBuilder newStr = new StringBuilder();
            for(int i = oldString.Length-1; i >= 0; i--)
            {
                newStr.Append(oldString[i]);
            }
            return newStr.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = null;
                int[] array2 = new int[3] { 1, 2, 3 };
                var indexTooLow = -1;
                var indexTooHigh = 100;
                var indexJustRight = 1;

                //GetValueAtIndex(array, -1);
                //GetValueAtIndex(array2, indexTooLow);
                //GetValueAtIndex(array2, indexTooHigh);
                GetValueAtIndex(array2, indexJustRight);

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static int GetValueAtIndex(int[] values, int index)
        {
            try
            {
                Console.WriteLine("Entering GetValueAtIndex...");
                if (values == null)
                {
                    throw new ArgumentNullException("Value cannot be null.");
                }
                if (index < 0 || index > values.Length - 1)
                {
                    var arrayLength = values.Length - 1;
                    throw new IndexOutOfRangeException($"Index must be between 0 and {arrayLength}.");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error in GetValueAtIndex");
                throw;
            }
            finally
            {
                Console.WriteLine("Exiting GetValueAtIndex...");
            }

            return values[index];
        }
    }
}

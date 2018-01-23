using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int SumArray(int[] values)
        {
            var sum = 0;

            if (values == null || values.Length == 0)
                return sum;

            foreach (var value in values)
                sum += value;

            return sum;
        }

        public static int GetValueAtIndex(int[] values, int index)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            if (index < 0 || index > values.Length - 1)
                throw new IndexOutOfRangeException();

            return values[index];
        }
    }
}

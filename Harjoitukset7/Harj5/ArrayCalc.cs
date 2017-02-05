using System.Linq;

namespace Harj5
{
    public class ArrayCalcs
    {
        public static double Sum(double[] array)
        {

            double sum = 0;
            foreach (double d in array)
            {
                sum = sum + d;
            }
            return sum;
        }

        public static double Average(double[] array)
        {

            return Sum(array) / array.Length;
        }

        public static double Min(double[] array)
        {

            return array.Min();
        }

        public static double Max(double[] array)
        {
            return array.Max();
        }
    }
}

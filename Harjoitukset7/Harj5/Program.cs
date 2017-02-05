using System;

namespace Harj5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCalculator();
        }
        static void TestCalculator()
        {
         double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
         Console.WriteLine("Sum = {0:##.00}", ArrayCalcs.Sum(array));
         Console.WriteLine("Avg = {0:##.00}", ArrayCalcs.Average(array));
         Console.WriteLine("Min = {0:##.00}", ArrayCalcs.Min(array));
         Console.WriteLine("Max = {0:##.00}", ArrayCalcs.Max(array));          
        }
    }
}

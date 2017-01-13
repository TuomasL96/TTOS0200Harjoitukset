using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("Anna Ikasi: ");
            age = Int32.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Alaikainen");
            }
            if (age >= 18 && age <= 65 )
            {
                Console.WriteLine("Aikuinen");
            }
           if (age > 65)
            {
                Console.WriteLine("Seniori");
            }
        }
    }
}

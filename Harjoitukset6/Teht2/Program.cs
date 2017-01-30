using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
        }
        static void ReadFile()
        {
            string file = @"d:\temp\nimet.txt";
            int nameCount = new int();

            try
            {
                var logFile = File.ReadAllLines(file);
                List<string> list = new List<string>(logFile);
                var q = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() });
          
                foreach (var x in q) { nameCount++; }
                list.Sort();

                Console.WriteLine("Löytyi " + list.Count + " riviä, ja " + nameCount + " nimeä sortattuna:");
                foreach (var x in q)
                {
                    Console.WriteLine("Nimi " + x.Value + " esiintyy " + x.Count + " kertaa");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            catch (Exception)
            {
                Console.WriteLine("Something Went wrong!");
            }
        }
    }
}

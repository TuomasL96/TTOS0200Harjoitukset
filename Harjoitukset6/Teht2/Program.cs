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
            FileReader();
        }
        static void FileReader()
        {
            string myFile = @"d:\temp\nimet.txt";
            if (File.Exists(myFile))
            {
                try
                {
                    List<string> lines = new List<string>(File.ReadAllLines(myFile));
                    lines.Sort();
                    var groupedList = lines.GroupBy(x => x) // LINQ
                                        .Select(g => new { Value = g.Key, Count = g.Count() });
                    Console.WriteLine("Löytyi " + lines.Count + " riviä, ja " + groupedList.Count() + " nimeä sortattuna:");
                    foreach (var x in groupedList)
                    {
                        Console.WriteLine("Nimi " + x.Value + " esiintyy " + x.Count + " kertaa");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else { Console.WriteLine("File: " + myFile + " does not exist!"); }
        }
    }
}

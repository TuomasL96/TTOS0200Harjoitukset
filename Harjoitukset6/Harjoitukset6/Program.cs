using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Harjoitukset6
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter();
        }
        static void TextWriter()
        {
            string endLine;
            bool repeat = true;
            string file = @"d:\temp\testfile.txt";

            while (repeat == true)
            {
                Console.Write("Give a text line ('exit' ends) : ");
                endLine = Console.ReadLine();
                if (endLine == "exit") { repeat = false; }
                else
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(file, true))
                        {
                            writer.WriteLine(endLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            Console.WriteLine("\nContents of " + file + ":");
            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(file));
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

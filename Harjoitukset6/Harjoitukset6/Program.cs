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
            string myFile = @"d:\temp\testfile.txt";
            bool repeat = true;

            while (repeat == true)
            {
                Console.Write("Give a text line ('0' ends) : ");
                endLine = Console.ReadLine();
                if (endLine == "0") { repeat = false; }
                else
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(myFile, true))
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
            Console.WriteLine("\nContents of " + myFile + ":");
            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(myFile));
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

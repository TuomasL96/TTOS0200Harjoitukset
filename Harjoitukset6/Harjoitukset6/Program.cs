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
            string textLine;
            bool repeat = true;
            string file = @"d:\temp\testfile.txt";
            System.IO.StreamWriter outputFile = null;

            while (repeat == true)
            {
                Console.Write("Give a text line (0 ends) : ");
                textLine = Console.ReadLine();
                if (textLine == "0") { repeat = false; }
                else
                {
                    try
                    {
                        outputFile = new System.IO.StreamWriter(file, true);
                        outputFile.WriteLine(textLine);
                        outputFile.Close();
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("Opened stream is null (ArgumentNullException)");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Opened stream is not writable (ArgumentException)");
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("An IO error happend (IOException)");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Some other exception happend (Exception)");
                    }
                    finally
                    {
                        if (outputFile != null)
                        {
                            outputFile.Close();
                        }
                    }
                }
            }
            Console.WriteLine("\nContents of " + file + ":");
            try
            {
                string[] lines = System.IO.File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            catch (Exception)
            {
                Console.WriteLine("Some exception happened!"); 
            }
        }
    }
}

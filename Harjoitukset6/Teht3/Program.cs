using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeAFile();
        }
        static void MakeAFile()
        {
            string number;
            int i;
            double f;
            bool repeat = true;
            /* 
            Voisi varmaan tehdä paljon yksinkertaisemmin/paremmin, nyt ohjelma aukoo ja sulkee tiedostot 
            joka numeron lisäyksen yhteydessä erikseen.
            */
            while (repeat == true)
            {
                Console.Write("Give a number: ");
                number = Console.ReadLine();
                bool isInt = int.TryParse(number, out i);
                if (isInt == true)
                {
                    System.IO.StreamWriter outputFile = null;
                    try
                    {
                        outputFile = new System.IO.StreamWriter(@"d:\temp\T2Integers.txt", true);
                        outputFile.WriteLine(i);
                        outputFile.Close();
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("File not found (FileNotFoundException)");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Some exception happend (Exception)");
                    }
                    finally
                    {
                        if (outputFile != null)
                        {
                            outputFile.Close();
                        }
                    }
                }
                else
                {
                    bool isDouble = double.TryParse(number, out f);
                    if (isDouble == true)
                    {
                        System.IO.StreamWriter outputFile = null;
                        try
                        {
                            outputFile = new System.IO.StreamWriter(@"d:\temp\T2Doubles.txt", true);
                            outputFile.WriteLine(f);
                            outputFile.Close();
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("File not found (FileNotFoundException)");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Some exception happend (Exception)");
                        }
                        finally
                        {
                            if (outputFile != null)
                            {
                                outputFile.Close();
                            }
                        }
                    }
                    else { repeat = false; }
                }
            }
        }
    }
}

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
            MakeAFileV2();
        }
        /// <summary>
        /// tämä versio tallentaa lopetettaessa kaikki annetut numerot kerralla
        /// ja kirjoittaa aina tiedostot uusiksi
        /// </summary>
        static void MakeAFileV2()
        {
            string number;
            int intValue;
            double doubleValue;
            bool isInt, isDouble, repeat = true;
            List<int> integers = new List<int>();
            List<double> doubles = new List<double>();

            while (repeat == true)
            {
                Console.Write("Give a number: ");
                number = Console.ReadLine();
                isInt = int.TryParse(number, out intValue);
                if (isInt == true)
                {
                    integers.Add(intValue);
                }
                else
                {
                    isDouble = double.TryParse(number, out doubleValue);
                    if (isDouble == true)
                    {
                        doubles.Add(doubleValue);
                    }
                    else { repeat = false; }
                }
            }
            try
            {
                using (StreamWriter intWriter = new StreamWriter(@"d:\temp\T2Integers.txt"))
                {
                    foreach (int i in integers)
                    {
                        intWriter.WriteLine(i);
                    }
                }
                using (StreamWriter doubleWriter = new StreamWriter(@"d:\temp\T2Doubles.txt"))
                {
                    foreach (double d in doubles)
                    {
                        doubleWriter.WriteLine(d);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// tämä versio avaa ja tallentaa tiedoston perään yksi numero kerrallaan 
        /// </summary>
        static void MakeAFile() 
        {
            string number;
            int intValue;
            double doubleValue;
            bool isInt, isDouble, repeat = true;
            while (repeat == true)
            {
                Console.Write("Give a number: ");
                number = Console.ReadLine();
                isInt = int.TryParse(number, out intValue);
                if (isInt == true)
                {
                    StreamWriter outputFile = null;
                    try
                    {
                        outputFile = new StreamWriter(@"d:\temp\T2Integers.txt", true);
                        outputFile.WriteLine(intValue);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
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
                    isDouble = double.TryParse(number, out doubleValue);
                    if (isDouble == true)
                    {
                        StreamWriter outputFile = null;
                        try
                        {
                            outputFile = new StreamWriter(@"d:\temp\T2Doubles.txt", true);
                            outputFile.WriteLine(doubleValue);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
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

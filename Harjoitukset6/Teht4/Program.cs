using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestTvShows();
        }

        static void TestTvShows()
        {
            List<TvShow> tvShows = new List<TvShow>();
            tvShows.Add(new TvShow("Myytinmurtajat", 21, "11:30", "12:30", "pölölölölölölölö"));
            tvShows.Add(new TvShow("Suomen huutokauppakeisari", 5, "9:30", "10:30", "alalalalalalala"));
            tvShows.Add(new TvShow("Hieno ohjelma", 5, "15:00", "16:00", "jujujujuujujjujuju"));
            tvShows.Add(new TvShow("Muumit", 2, "18:00", "19:00", "ummumumumumumumumum"));
            tvShows.Add(new TvShow("Testi", 99, "00:00", "10:00", "zxzxzxzxzxzxzxzxzx"));

            try
            {
                Stream writeMultipleStream = new FileStream("TVShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writeMultipleStream, tvShows);
                writeMultipleStream.Close();

                Stream openStream = new FileStream("TVShows.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                List<TvShow> readTvShows = (List<TvShow>)formatter.Deserialize(openStream);
                openStream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (TvShow tvshow in tvShows)
            {
                Console.WriteLine(tvshow.PrintShow() + "\n===========================");
            }
        }
    }
}

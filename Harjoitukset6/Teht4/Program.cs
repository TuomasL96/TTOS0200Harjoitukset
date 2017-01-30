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
            SaveTvShows();
        }
        static void SaveTvShows()
        {
            List<TvShow> tvShows = new List<TvShow>();
            tvShows.Add(new TvShow("Myytinmurtajat", 21, "11:30", "12:30", "pölölölölölölölö"));
            tvShows.Add(new TvShow("Suomen huutokauppakeisari", 5, "9:30", "10:30", "alalalalalalala"));
            tvShows.Add(new TvShow("Hieno ohjelma", 5, "15:00", "16:00", "jujujujuujujjujuju"));
            tvShows.Add(new TvShow("Muumit", 2, "18:00", "19:00", "ummumumumumumumumum"));

            Stream writeStream = new FileStream("TVShows.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, tvShows);
            writeStream.Close();

            Stream readStream = new FileStream("TVShows.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            TvShow readtvShow = (TvShow)formatter.Deserialize(readStream);
            Console.WriteLine("TVShow: {0} {1}", TvShow.Name);
        }
    }
}

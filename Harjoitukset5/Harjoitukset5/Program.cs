using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset5
{
    class Program
    {
        static void Main(string[] args)
        {
            Songs Kappaleet = new Songs();
            Song song1 = new Song { Name = "Songmame1", Length = "6:47" };
            Song song2 = new Song { Name = "Songmame2", Length = "2:39" };
            Song song3 = new Song { Name = "Songmame3", Length = "1:47" };
            Song song4 = new Song { Name = "Songmame4", Length = "2:17" };
            Song song5 = new Song { Name = "Songmame5", Length = "3:11" };
            Song song6 = new Song { Name = "Songmame6", Length = "1:50" };
            Kappaleet.AddSong(song1);
            Kappaleet.AddSong(song2);
            Kappaleet.AddSong(song3);
            Kappaleet.AddSong(song4);
            Kappaleet.AddSong(song5);
            Kappaleet.AddSong(song6);
            Console.WriteLine();
            foreach (var item in Kappaleet.PrintSongs)
            {
                Console.WriteLine()
            }
        }
    }
}

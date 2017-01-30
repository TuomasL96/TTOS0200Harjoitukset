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
            Cd cd = new Cd("Endless Forms Most Beautiful", "Nightwish");

            cd.AddSong("Shudder Before the Beautiful", "6:29");
            cd.AddSong("Weak Fantasy", "5:23");
            cd.AddSong("Elan", "4:45");
            cd.AddSong("Yours Is an Empty Hope", "5:34");
            cd.AddSong("Our Decades in the Sun", "6:37");

            Console.WriteLine(cd.ToString());
        }
    }
}

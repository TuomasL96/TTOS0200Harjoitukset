using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitukset5
{
    class Cd
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public List<string> Songs = new List<string>();

        public Cd(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }

        public void AddSong(string name, string lenght)
        {
            string song = name + ", " + lenght;
            Songs.Add(song);
        }

        private string PrintSongs()
        {
            string print = "";
            for (int i = 0; i < Songs.Count; i++)
            {
                print += "  - " + Songs[i] + "\n";
            }
            return print;
        }

        public override string ToString()
        {
            return "CD Data:\n- name:" + Name + "\n- artist:" + Artist + "\n- songs:\n" + PrintSongs();
        }
    }
}


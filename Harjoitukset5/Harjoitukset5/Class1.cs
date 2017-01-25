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
        public Cd(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
    }
    class Song
    {
        public string Name { get; set; }
        public string Length { get; set; }
        public override string ToString()
        {
            return Name + "," + Length;
        }
    }
    class Songs
    {
        private List<Song> songs;
        public List<Song> PrintSongs
        {
            get { return songs; }
        }
        public Songs()
        {
            songs = new List<Song>();
        }
        public void AddSong(Song song)
        {
            songs.Add(song);
        }
    }
}


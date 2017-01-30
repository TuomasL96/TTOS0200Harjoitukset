using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harj4
{
    class Team
    {
        public List<string> Players = new List<string>();
        public string TeamName { get; set; }
        public string HomeTown { get; set; }
        public void AddPlayer(string name, string lenght, int age, int playerId)
        {
            string player = name + ", " + lenght + " , " + age + " , " + playerId;
            Players.Add(player);
        }
        public List<Player> RemovePlayer(int playerId)
        {//ei valmis
        }
        public Team(string name, string town)
        {
            TeamName = name;
            HomeTown = town;
        }
    }
    class Player
    {
        public string FistName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public int PlayerId { get; set; }

    }
}

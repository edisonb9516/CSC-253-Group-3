using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Player
{
    public class Player
    {
        // Auto generated backing fields

        public string Name { get; set; }
        public string Password { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Hp { get; set; }

        // will require all properties so no base default constructor
        public Player(string name, string password, string classType, string race, int hp)
        {
            Name = name;
            Password = password;
            Class = classType;
            Race = race;
            Hp = hp;
        }

        // Holds player objects in list currently this will later be held in a database or document.

        public static List<Player> players = new List<Player>();

    }
}

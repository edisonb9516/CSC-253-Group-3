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
        public int CurrentHP { get; set; }
        public int Evasion { get; set; }

        public int Attack { get; set; }
        public static Location.Room CurrentRoom { get; set; }
        // TODO add weapon this will be set to zero/null in new player constructor and saved and loaded as weaponID which will be used to generate the weapon object 

        // will require all properties so no base default constructor
        public Player(string name, string password, string classType, string race, int hp, int evasion, int attack)
        {
            Name = name;
            Password = password;
            Class = classType;
            Race = race;
            Hp = hp;
            // current hp is equal to starting hp
            CurrentHP = hp;
            Attack = attack;
            Evasion = evasion;
            // current location is first Room in rooms list when generated
            CurrentRoom = Location.Room.rooms[0];
            // will probably handle weapons and other equip / inventory items in a similar way as the location
        }
        public Player(string name, string password, string classType, string race, int hp, int currentHP, int roomID, int evasion, int attack)
        {
            Name = name;
            Password = password;
            Class = classType;
            Race = race;
            Hp = hp;
            CurrentHP = currentHP;
            CurrentRoom = Location.Room.rooms[roomID];
            Evasion = evasion;
            Attack = attack;
        }

        // Holds player objects in list currently this will later be held in a database or document.
        public static List<Player> players = new List<Player>();

    }
}

using Engine.Core.ParentCharacterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Player
{
    public class Player : ParentClassForCharacters

    {
        
        // TODO Think about giving Mobs actual weapons and Room ID for movement although this would make room generation have to be rethought

        public string Password { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int CurrentHP { get; set; }
        public int RoomId { get; set; }
        public Items_Inventory.Weapon Weapon { get; set; }
        // todo player has inventory but it is not saved or used currently. when player gets an item copy the generated item in the room and add to inventory then delete item in room
        public Items_Inventory.IInventory Inventory { get; set; }

        public static Location.Room CurrentRoom { get; set; }
        // TODO add weapon this will be set to zero/null in new player constructor and saved and loaded as weaponID which will be used to generate the weapon object
        // Same with Inventory/Items

        public static Player _player;
        // will require all properties so no base default constructor
        public Player(string name, string password, string classType, string race, int hp, int evasion, int attack, int gold) : base(name,hp,attack,evasion,gold)
        {
            Password = password;
            Class = classType;
            Race = race;
            
            // current hp is equal to starting hp
            CurrentHP = hp;
            // current location is first Room in rooms list when generated
            CurrentRoom = Location.Room.rooms[0];
            // will probably handle weapons and other equip / inventory items in a similar way as the location

            // Since this constructor is only for new players you can set gold to zero
            Gold = gold;

            // TODO This always gives player daggers need to change later using this for combat now
            this.Weapon = Items_Inventory.Weapon.weapons[2];
        }
        public Player(string name, string password, string classType, string race, int hp, int currentHP, int roomID, int evasion, int attack, int gold) : base(name, hp, attack, evasion, gold)
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
            Gold = gold;

            // TODO This always gives player daggers need to change later using this for combat now
            this.Weapon = Items_Inventory.Weapon.weapons[2];
        }

        // Holds player objects in list currently this will later be held in a database or document.
        public static List<Player> players = new List<Player>();

        public Player()
        {

        }
    }
}

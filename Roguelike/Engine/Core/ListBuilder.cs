using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.Core
{
    public class ListBuilder
    {

        public static void Build()
        {
            // Had to move mobs to top so the list builds first since rooms depend on the mobs list to add mobs
            #region Build Mobs
            NPC.Mob.mobs = SqliteDataAccess.LoadMobs();
            // Old code building from csv LEAVE INCASE NEEDED IF DATABASE ISNT WORKING
            //using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Mobs.csv"))
            //{
            //    reader.ReadLine();
            //    while (!reader.EndOfStream)
            //    {
            //        string[] tokens = reader.ReadLine().Split(',');

            //        NPC.Mob.mobs.Add(new NPC.Mob(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6])));
            //    }
            //    reader.Close();
            //}
            #endregion

            #region Build Items
            Items_Inventory.Items.items = SqliteDataAccess.LoadItems();

            // Old code building from csv LEAVE INCASE NEEDED IF DATABASE ISNT WORKING
            //using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Items.csv"))
            //{
            //    reader.ReadLine();

            //    while (!reader.EndOfStream)
            //    {
            //        string[] tokens = reader.ReadLine().Split(',');

            //        Items_Inventory.Items.items.Add(new Items_Inventory.Items(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4])));
            //    }
            //    reader.Close();

            //}
            #endregion

            #region Build Potions
            Items_Inventory.Potion.potions = SqliteDataAccess.LoadPotions();
            // Old code building from csv LEAVE INCASE NEEDED IF DATABASE ISNT WORKING
            //using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Potions.csv"))
            //{
            //    reader.ReadLine();

            //    while (!reader.EndOfStream)
            //    {
            //        string[] tokens = reader.ReadLine().Split(',');

            //        Items_Inventory.Potion.potions.Add(new Items_Inventory.Potion(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3])));
            //    }
            //    reader.Close();

            //}
            #endregion

            #region Build Treasure
            Items_Inventory.Treasure.treasures = SqliteDataAccess.LoadTreasure();
            // Old code building from csv LEAVE INCASE NEEDED IF DATABASE ISNT WORKING
            //using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Treasure.csv"))
            //{
            //    reader.ReadLine();

            //    while (!reader.EndOfStream)
            //    {
            //        string[] tokens = reader.ReadLine().Split(',');

            //        Items_Inventory.Treasure.treasures.Add(new Items_Inventory.Treasure(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4])));
            //    }
            //    reader.Close();

            //}
            #endregion

            #region Build Weapons

            Items_Inventory.Weapon.weapons = SqliteDataAccess.LoadWeapons();

            // Old code building from csv LEAVE INCASE NEEDED IF DATABASE ISNT WORKING
            //using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Weapons.csv"))
            //{
            //    reader.ReadLine();

            //    while (!reader.EndOfStream)
            //    {
            //        string[] tokens = reader.ReadLine().Split(',');

            //        Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4])));
            //    }
            //    reader.Close();

            //}
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(801, "Broadsword", "Normal sized sword with normal sized damage", 30));
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(802, "Claymore", "Huge sword does a lot of damage", 50));     // movement speed * .67
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(803, "Daggers", "Small daggers lets you move faster while attacking", 25));       // movement speed * 1.5
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(804, "Dragonslayer Bow", "Well crafted bow that keeps you farther away from combat", 25));        // evasion * 2
            #endregion
            // Had to move rooms to the bottom to keep the same problem from happening like it did with mobs see top comment
            #region Build Rooms
            Location.Room.rooms = SqliteDataAccess.LoadRooms();
            // Had to do this outside of building since Dapper uses the default constructor
            foreach (Location.Room room in Location.Room.rooms)
            {
                if (room.MonsterId >= 300)
                {
                    // TODO if we want add another if statement after a random object so that monster encounters are random
                    room.RoomMob = new NPC.Mob(NPC.Mob.mobs[room.MonsterId - 300]);
                    room.RoomMobs.Add(new NPC.Mob(room.RoomMob));
                }
            }
            // Old code building from csv LEAVE INCASE NEEDED IF DATABASE ISNT WORKING
            //using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Rooms.csv"))
            //{
            //    reader.ReadLine();

            //    while (!reader.EndOfStream)
            //    {
            //        string[] tokens = reader.ReadLine().Split(',');

            //        Location.Room.rooms.Add(new Location.Room(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]),
            //            int.Parse(tokens[6]), int.Parse(tokens[7]), int.Parse(tokens[8])));
            //    }
            //    reader.Close();

            //}
            #endregion

            #region Build Player List
            Player.Player.players = SqliteDataAccess.LoadPlayers();
            // Had to do this outside of building since Dapper uses the default constructor
            foreach (Player.Player player in Player.Player.players)
            {
                // TODO change to saved weapon id or inventory something
                player.Weapon = Items_Inventory.Weapon.weapons[2];
            }
            #endregion
        }
    }
}
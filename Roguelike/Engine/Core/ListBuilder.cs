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
            // TODO build lists here reading from .txt files and building to object lists

            #region Build Rooms

            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Rooms.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());

                    string name = reader.ReadLine();

                    string description = reader.ReadLine();

                    int northExit = int.Parse(reader.ReadLine());

                    int southExit = int.Parse(reader.ReadLine());

                    int eastExit = int.Parse(reader.ReadLine());

                    int westExit = int.Parse(reader.ReadLine());

                    int monsterId = int.Parse(reader.ReadLine());

                    int itemID = int.Parse(reader.ReadLine());

                    Location.Room.rooms.Add(new Location.Room(id, name, description, northExit, southExit, eastExit, westExit, monsterId, itemID));
                }
            }
            #endregion

            #region Build Items

            // TODO read from file instead of hard coding
            Items_Inventory.Items.items.Add(new Items_Inventory.Items(501, "Torch", "Can light up a dark room"));
            Items_Inventory.Items.items.Add(new Items_Inventory.Items(502, "Key", "Can open some door somewhere"));
            Items_Inventory.Items.items.Add(new Items_Inventory.Items(503, "Locket", "Inside is a picture of a King, Queen, and Princess"));
            Items_Inventory.Items.items.Add(new Items_Inventory.Items(504, "Shirt", "This shirt has fresh blood on it. Who did it belong to?"));
            #endregion

            #region Build Potions

            // TODO read from file instead of hard coding
            Items_Inventory.Potion.potions.Add(new Items_Inventory.Potion(601, "Small Health Potion", "Heals A small amount of HP (25).", 25));
            Items_Inventory.Potion.potions.Add(new Items_Inventory.Potion(602, "Large Health Potion", "Heals A large amount of HP (75).", 75));
            #endregion

            #region Build Treasure
            // TODO read from file instead of hard coding
            Items_Inventory.Treasure.treasures.Add(new Items_Inventory.Treasure(701, "Diamond", "Small diamond worth a lot of gold", 200));
            Items_Inventory.Treasure.treasures.Add(new Items_Inventory.Treasure(702, "Crystal Orb", "Sphere of crystal, worth a lot of gold to the right buyer", 100));
            Items_Inventory.Treasure.treasures.Add(new Items_Inventory.Treasure(703, "Music Box", "Someone treasured this music box in the past. Maybe they will reward you if you can find them", 100));
            #endregion

            #region Build Weapons

            // TODO read from file instead of hard coding
            Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(801, "Broadsword", "Normal sized sword with normal sized damage", 30));
            Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(802, "Claymore", "Huge sword does a lot of damage", 50));     // movement speed * .67
            Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(803, "Daggers", "Small daggers lets you move faster while attacking", 25));       // movement speed * 1.5
            Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(804, "Dragonslayer Bow", "Well crafted bow that keeps you farther away from combat", 25));        // evasion * 2
            #endregion

            #region Build Mobs
            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Mobs.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());

                    string name = reader.ReadLine();

                    string description = reader.ReadLine();

                    int hp = int.Parse(reader.ReadLine());

                    int damage = int.Parse(reader.ReadLine());

                    NPC.Mob.mobs.Add(new NPC.Mob(id, name, description, hp, damage));
                }
            }
                    #endregion
        }
    }
}

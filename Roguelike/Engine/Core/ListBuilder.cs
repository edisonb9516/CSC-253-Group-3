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
        private static string[] GetNextLine(StreamReader reader)
        {
            return reader.ReadLine().Split(' ');
        }
        public static void Build()
        {
            // TODO build lists here reading from .txt files and building to object lists

            #region Build Rooms

            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Rooms.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(GetNextLine(reader)[0]);

                    string name = GetNextLine(reader)[0];

                    string description = GetNextLine(reader)[0];

                    int northExit = int.Parse(GetNextLine(reader)[0]);

                    int southExit = int.Parse(GetNextLine(reader)[0]);

                    int eastExit = int.Parse(GetNextLine(reader)[0]);

                    int westExit = int.Parse(GetNextLine(reader)[0]);

                    int monsterId = int.Parse(GetNextLine(reader)[0]);

                    int itemID = int.Parse(GetNextLine(reader)[0]);

                    Location.Room.rooms.Add(new Location.Room(id, name, description, northExit, southExit, eastExit, westExit, monsterId, itemID));
                }
            }
            #endregion

            #region Build Items

            // adding one item for now
            Items_Inventory.Items.items.Add(new Items_Inventory.Items(501, "Torch", "Can light up a dark room"));
            #endregion

            #region Build Potions

            // adding one for now
            Items_Inventory.Potion.potions.Add(new Items_Inventory.Potion(601, "Small Health Potion", "Heals A small amount of HP (25).", 25));
            #endregion

            #region Build Treasure
            // adding one for now
            Items_Inventory.Treasure.treasures.Add(new Items_Inventory.Treasure(701, "Diamond", "Small diamond worth a lot of gold", 100));
            #endregion

            #region Build Weapons

            Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(801, "Broadsword", "Normal sized sword with normal sized damage", 20));
            #endregion

            #region Build Mobs
            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Mobs.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(GetNextLine(reader)[0]);

                    string name = GetNextLine(reader)[0];

                    string description = GetNextLine(reader)[0];

                    int hp = int.Parse(GetNextLine(reader)[0]);

                    int damage = int.Parse(GetNextLine(reader)[0]);

                    NPC.Mob.mobs.Add(new NPC.Mob(id, name, description, hp, damage));
                }
            }
                    #endregion
        }
    }
}

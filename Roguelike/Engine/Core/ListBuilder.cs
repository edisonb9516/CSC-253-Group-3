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

            #region Build Rooms

            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Rooms.csv"))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    Location.Room.rooms.Add(new Location.Room(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5]),
                        int.Parse(tokens[6]), int.Parse(tokens[7]), int.Parse(tokens[8])));
                }
                reader.Close();

            }
            #endregion

            #region Build Items

            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Items.csv"))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    Items_Inventory.Items.items.Add(new Items_Inventory.Items(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4])));
                }
                reader.Close();

            }
            #endregion

            #region Build Potions

            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Potions.csv"))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    Items_Inventory.Potion.potions.Add(new Items_Inventory.Potion(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3])));
                }
                reader.Close();

            }
            #endregion

            #region Build Treasure

            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Treasure.csv"))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    Items_Inventory.Treasure.treasures.Add(new Items_Inventory.Treasure(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4])));
                }
                reader.Close();

            }
            #endregion

            #region Build Weapons
            // TODO add more weapons to weapons.csv for a total of 12
            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Weapons.csv"))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4])));
                }
                reader.Close();

            }
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(801, "Broadsword", "Normal sized sword with normal sized damage", 30));
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(802, "Claymore", "Huge sword does a lot of damage", 50));     // movement speed * .67
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(803, "Daggers", "Small daggers lets you move faster while attacking", 25));       // movement speed * 1.5
            //Items_Inventory.Weapon.weapons.Add(new Items_Inventory.Weapon(804, "Dragonslayer Bow", "Well crafted bow that keeps you farther away from combat", 25));        // evasion * 2
            #endregion

            #region Build Mobs
            // TODO add more mobs to mobs.csv for a total of 15
            using (StreamReader reader = File.OpenText(@"../../../Engine/Assets/Mobs.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');

                    NPC.Mob.mobs.Add(new NPC.Mob(int.Parse(tokens[0]), tokens[1], tokens[2], int.Parse(tokens[3]), int.Parse(tokens[4]), int.Parse(tokens[5])));
                }
                reader.Close();
            }
                    #endregion
        }
    }
}

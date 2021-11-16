using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class SqliteDataAccess
    {
        public static List<Core.Player.Player> LoadPlayers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Core.Player.Player>("select Name Name, Password Password, Class Class, Race Race, HP Hp, CurrentHP CurrentHP, RoomID RoomId, Evasion Evasion, Attack Attack, Gold Gold from Players");
                return output.ToList();
            }
        }
        public static void SavePlayer(Core.Player.Player player, string saveType)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                if (saveType.Equals("new"))
                {
                    cnn.Execute($"INSERT INTO Players([Name],[Password],[Class],[Race],[HP],[CurrentHP],[RoomID],[Evasion],[Attack],[Gold]) VALUES (@Name, @Password, @Class, @Race, @HP, @CurrentHP, @RoomID, @Evasion, @Attack, @Gold)", player);
                }
                if (saveType.Equals("overwrite"))
                {
                    cnn.Execute($"UPDATE Players SET CurrentHP = @CurrentHP, RoomID = @RoomID, Gold = @Gold WHERE Name = @Name", player);
                }
            }
        }

        public static List<Core.Items_Inventory.Weapon> LoadWeapons()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Core.Items_Inventory.Weapon>("select ID Id, Name Name, Description Description, Attack Attack, Price Price, Type DamageType from Weapons");
                return output.ToList();
            }
        }

        public static List<Core.Location.Room> LoadRooms()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Core.Location.Room>("select ID Id, NAME Name, DESCRIPTION Description, NORTHEXITID NorthExit, SOUTHEXITID SouthExit, EASTEXITID EastExit, WESTEXITID WestExit, MOBID MonsterId, ITEMID ItemID from Rooms");
                return output.ToList();
            }
        }

        public static List<Core.NPC.Mob> LoadMobs()
        {
            // More specific SQL statement to build properly
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Core.NPC.Mob>("Select ID Id, Name Name, Description Description, HP Hp, Attack Damage, Gold Gold, Evasion Evasion FROM Mobs");
                return output.ToList();
            }
        }

        public static List<Core.Items_Inventory.Items> LoadItems()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Core.Items_Inventory.Items>("select ID Id, Name Name, Description Description, Price Price from Items");
                return output.ToList();
            }
        }

        public static List<Core.Items_Inventory.Potion> LoadPotions()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Core.Items_Inventory.Potion>("select ID Id, Name Name, Description Description, Value Value from Potions");
                return output.ToList();
            }
        }

        public static List<Core.Items_Inventory.Treasure> LoadTreasure()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Core.Items_Inventory.Treasure>("select ID Id, Name Name, Description Description, Quest Quest from Treasure");
                return output.ToList();
            }
        }
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}

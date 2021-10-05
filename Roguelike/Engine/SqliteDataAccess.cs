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
                var output = cnn.Query<Core.Player.Player>("select * from Players", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SavePlayer(Core.Player.Player player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // search the player table for similar info before saving and overwrite if necessary
                // todo sql statement in cnn.execute string pass to input the player save
                cnn.Execute("", player);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}

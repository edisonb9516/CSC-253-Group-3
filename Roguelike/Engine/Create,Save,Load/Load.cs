using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Create_Save_Load
{
    public static class Load
    {
        internal static string LoadPlayer(string[] tokens)
        {
            try
            {
                Core.Player.Player.players.Add(new Core.Player.Player(tokens[0], tokens[1], tokens[2], tokens[3], int.Parse(tokens[4]), int.Parse(tokens[5]), int.Parse(tokens[6]), int.Parse(tokens[7])
                    int.Parse(tokens[8])));

                return "Loaded";
            }
            catch (Exception ex)
            {
                return "Something Went Wrong!  ---  " + ex.Message;
            }
        }
    }
}

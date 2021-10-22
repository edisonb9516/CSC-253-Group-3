using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Create_Save_Load
{
    public static class Load
    {
        internal static string LoadPlayer(Core.Player.Player player)
        {
            try
            {
                Core.Player.Player.CurrentRoom = Core.Location.Room.rooms[player.RoomId];
                Core.Player.Player._player = player;

                return "Loaded";
            }
            catch (Exception ex)
            {
                return "Something Went Wrong!  ---  " + ex.Message;
            }
        }
    }
}

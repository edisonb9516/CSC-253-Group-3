using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public class Attack
    {
        internal static string AttackEnemy()
        {
            if (Core.Player.Player.CurrentRoom.RoomMob == null)
            {
                return "There is no enemy here to attack!";
            }
            else
            {
                Core.NPC.Mob enemy = Core.Player.Player.CurrentRoom.RoomMobs[Core.Player.Player.CurrentRoom.RoomMobs.Count - 1];

                Core.Combat.Combat.Fight(enemy, Core.Player.Player._player);
                // TODO currently after a fight the mob name is displayed again in the room then says done fighting, ideally instead
                // of done fighting we would remove the mob from the room list which would fix the issue of the mob name showing as
                // well as go from done fighting to no enemy to attack

                return "Done Fighting";
            }
        }
    }
}

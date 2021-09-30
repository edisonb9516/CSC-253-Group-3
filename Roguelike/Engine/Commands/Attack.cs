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

                Core.Combat.Combat.Fight(enemy, Core.Player.Player.players[0]);

                return "Done Fighting";
            }
        }
    }
}

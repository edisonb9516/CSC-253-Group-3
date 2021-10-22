using Engine.Core.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public class Movement
    {
        // since this is a void method need a static variable to determine output if cant move
        public static bool cantGo = false;
        public static void Move(string direction)
        {
            switch (direction)
            {
                case "north":
                    if (Core.Player.Player.CurrentRoom.NorthExit != -1)
                    {
                        cantGo = false;
                        MoveRooms(Room.rooms[Core.Player.Player.CurrentRoom.NorthExit]);
                    }
                    else
                    {
                        cantGo = true;
                    }
                    break;
                case "south":
                    if (Core.Player.Player.CurrentRoom.SouthExit != -1)
                    {
                        cantGo = false;
                        MoveRooms(Room.rooms[Core.Player.Player.CurrentRoom.SouthExit]);
                    }
                    else
                    {
                        cantGo = true;
                    }
                    break;
                case "east":
                    if (Core.Player.Player.CurrentRoom.EastExit != -1)
                    {
                        cantGo = false;
                        MoveRooms(Room.rooms[Core.Player.Player.CurrentRoom.EastExit]);
                    }
                    else
                    {
                        cantGo = true;
                    }
                    break;
                case "west":
                    if (Core.Player.Player.CurrentRoom.WestExit != -1)
                    {
                        cantGo = false;
                        MoveRooms(Room.rooms[Core.Player.Player.CurrentRoom.WestExit]);
                    }
                    else
                    {
                        cantGo = true;
                    }
                    break;
            }
        }

        public static void MoveRooms(Room room)
        {
            Core.Player.Player.CurrentRoom = room;

            if (Core.Player.Player.CurrentRoom.RoomMob != null)
            {
                Core.Player.Player.CurrentRoom.RoomMobs.Add(new Core.NPC.Mob(Core.Player.Player.CurrentRoom.RoomMob));
            }

            if (Core.Player.Player.CurrentRoom == Room.rooms[2])
            {
                // heal to full if in bedroom might add another place later
                Core.Player.Player._player.CurrentHP = Core.Player.Player._player.Hp;
            }
        }
    }
}

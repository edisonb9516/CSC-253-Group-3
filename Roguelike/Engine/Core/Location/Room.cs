using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Location
{
    public class Room
    {
        // List of rooms
        public static List<Room> rooms = new List<Room>();

        public Room(int id, string name, string description, int northExit, int southExit, int eastExit, int westExit, int monsterId, int itemID)
        {
            Id = id;
            Name = name;
            Description = description;
            NorthExit = northExit;
            SouthExit = southExit;
            EastExit = eastExit;
            WestExit = westExit;
            MonsterId = monsterId;
            ItemID = itemID;

            if (MonsterId >= 0)
            {
                // TODO if we want add another if statement after a random object so that monster encounters are random
                RoomMob = new NPC.Mob(NPC.Mob.mobs[monsterId - 300]);
                RoomMobs.Add(new NPC.Mob(RoomMob));
            }
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int NorthExit { get; }
        public int SouthExit { get; }
        public int EastExit { get; }
        public int WestExit { get; }
        public int MonsterId { get; }
        public int ItemID { get; }
        public NPC.Mob RoomMob { get; set; }

        public List<NPC.Mob> RoomMobs = new List<NPC.Mob>();

        public Room()
        {
            //if (MonsterId >= 300)
            //{
            //    TODO if we want add another if statement after a random object so that monster encounters are random
            //    RoomMob = new NPC.Mob(NPC.Mob.mobs[MonsterId - 300]);
            //    RoomMobs.Add(new NPC.Mob(RoomMob));
            //}
        }
    }
}

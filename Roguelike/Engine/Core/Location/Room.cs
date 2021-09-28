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

        // TODO Replace monsterId with actual Mob Object then later save as ID instead
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
    }
}

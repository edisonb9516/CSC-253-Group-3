using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Location
{
    public static class CurrentLocation
    {
        public static void DisplayCurrentLocation()
        {
            // TODO Make UI insensitive i.e. Get rid of Console.Writelines

            Console.WriteLine($"You are at: {Player.Player.CurrentRoom.Name}");
            Console.WriteLine(Player.Player.CurrentRoom.Description);

            List<string> exits = FindExits(Player.Player.CurrentRoom);

            string showExits = "-- Exits --\n";

            foreach (string exit in exits)
            {
                showExits += exit;
            }
            Console.WriteLine(showExits);
            Console.WriteLine("-- Enemy --");
            if (Player.Player.CurrentRoom.RoomMob == null)
            {
                Console.WriteLine("No Enemies!");
            }
            else
            {
                Console.WriteLine(Player.Player.CurrentRoom.RoomMob.Name);
            }
        }

        private static List<string> FindExits(Room currentRoom)
        {
            // this one is good on being UI insensitive
            List<string> exits = new List<string>();

            if (Player.Player.CurrentRoom.NorthExit >= 0)
            {
                exits.Add(" north: " + Room.rooms[Player.Player.CurrentRoom.NorthExit].Name + "\n");
            }
            if (Player.Player.CurrentRoom.SouthExit >= 0)
            {
                exits.Add(" south: " + Room.rooms[Player.Player.CurrentRoom.SouthExit].Name + "\n");
            }
            if (Player.Player.CurrentRoom.EastExit >= 0)
            {
                exits.Add(" east: " + Room.rooms[Player.Player.CurrentRoom.EastExit].Name + "\n");
            }
            if (Player.Player.CurrentRoom.WestExit >= 0)
            {
                exits.Add(" west: " + Room.rooms[Player.Player.CurrentRoom.WestExit].Name + "\n");
            }

            return exits;
        }
    }
}

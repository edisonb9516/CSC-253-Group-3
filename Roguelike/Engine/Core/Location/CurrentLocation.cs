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
            Console.WriteLine($"You are at: {Player.Player.CurrentRoom.Name}");
            Console.WriteLine(Player.Player.CurrentRoom.Description);
            // TODO display other information about room other than name and description exits etc

            List<string> exits = FindExits(Player.Player.CurrentRoom);

            string showExits = "Exits -- ";

            foreach (string exit in exits)
            {
                showExits += exit;
            }
        }

        private static List<string> FindExits(Room currentRoom)
        {
            List<string> exits = new List<string>();

            if (Player.Player.CurrentRoom.NorthExit >= 0)
            {
                exits.Add(" north: " + Room.rooms[Player.Player.CurrentRoom.NorthExit].Name);
            }
            if (Player.Player.CurrentRoom.SouthExit >= 0)
            {
                exits.Add(" south: " + Room.rooms[Player.Player.CurrentRoom.SouthExit].Name);
            }
            if (Player.Player.CurrentRoom.EastExit >= 0)
            {
                exits.Add(" east: " + Room.rooms[Player.Player.CurrentRoom.EastExit].Name);
            }
            if (Player.Player.CurrentRoom.WestExit >= 0)
            {
                exits.Add(" west: " + Room.rooms[Player.Player.CurrentRoom.WestExit].Name);
            }

            return exits;
        }
    }
}

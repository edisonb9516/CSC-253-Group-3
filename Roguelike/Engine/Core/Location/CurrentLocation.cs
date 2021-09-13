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
            // TODO display other information about room other than name and description
        }
    }
}

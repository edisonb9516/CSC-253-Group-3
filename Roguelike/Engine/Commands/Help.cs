using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public static class Help
    {
        // TODO Make UI insensitive i.e. Get rid of Console.Writelines
        public static void DisplayHelpInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Available commands                     ");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("North - Move North                     ");
            Console.WriteLine("South - Move South                     ");
            Console.WriteLine("East - Move East                       ");
            Console.WriteLine("West - Move West                       ");
            Console.WriteLine("Attack - Deal Damage                   ");
            Console.WriteLine("Exit - Exit the Game                   ");
            Console.WriteLine("Rooms - Displays Rooms                 ");
            Console.WriteLine("Items - Displays Items                 ");
            Console.WriteLine("Weapons - Displays Weapons             ");
            Console.WriteLine("Potions - Displays Potions             ");
            Console.WriteLine("Enemies - Displays Enemies             ");
            Console.WriteLine("Treasure - Displays Treasure           ");
            Console.WriteLine("Location - Displays Current Location   ");
            Console.WriteLine("Gold - Displays Current Amount of Gold ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}

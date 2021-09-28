using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core
{
    public class StandardMessages
    {
        // TODO Make UI insensitive i.e. Get rid of Console.Writelines Make them all return strings instead of Writeline
        public static void ViewAfterChoice(string choice)
        {
            Console.WriteLine("");
            Console.WriteLine($"{choice}:");
            Console.WriteLine("_______________________________________________");
        }

        public static void ChoiceError()
        {
            Console.WriteLine("Not a choice!");
        }
        public static void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Type 'Help' to see a list of commands");
            Console.WriteLine("");

            Console.WriteLine("1. Move North");
            Console.WriteLine("2. Move South");
            Console.WriteLine("3. Move East");
            Console.WriteLine("4. Move West");
            Console.WriteLine("5. Attack");
            Console.WriteLine("6. Exit");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.Write("Enter a choice >> ");
        }

        public static void DisplayLocation()
        {
            // TODO show exit options in location
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Location.CurrentLocation.DisplayCurrentLocation();
        }
        public static void BreakApartDisplay()
        {
            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("");
        }
    }
}

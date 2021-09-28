using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

/**
* 9/26/2021
* CSC 253
* Kevin Griffin, Brandon Edison, Adrian Gorum
* Read objects from files and save player information to be searched and loaded, combat, and other things
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.Core.ListBuilder.Build();

            // Welcome screen and player loading
            Engine.Create_Save_Load.Intoduction.Welcome();

            // Main Menu

            while(Engine.Commands.Command.exit == false)
            {
                Engine.Core.StandardMessages.DisplayMenu();

                string input = Console.ReadLine();

                // ignore whitespace
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                Engine.Commands.Command.CheckInput(ref input);

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Engine.Commands.Command.CommandSelection(input);
            }
            // TODO create a search function for everything other than player that searches by id and returns objects

            Console.WriteLine(Engine.Create_Save_Load.Save.SavePlayer());
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

/**
* 9/12/2021
* CSC 253
* Kevin Griffin, Brandon Edison, Adrian Gorum
* Start of the project, repurposing classes and methods from the fist semesters' project and building onto it with new classes and features
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Build Lists -- finishing this is where most of our work is done in sprint 1
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
        }
    }
}

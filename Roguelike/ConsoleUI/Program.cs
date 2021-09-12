using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

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
                Engine.Core.StandardMessages.DisplayLocation();
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

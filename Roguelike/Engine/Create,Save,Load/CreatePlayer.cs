using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.Create_Save_Load
{
    public class CreatePlayer
    {
        // TODO Make UI insensitive i.e. Get rid of Console.Writelines
        public static void CreateNewPlayer()
        {
            string name = "";
            string classType = "";
            string race = "";
            string password = "";
            int hp = 0;
            int evasion = 0;
            int attack = 0;
            bool stopClass = false;
            bool stopRace = false;
            bool stopPassword = false;
            bool stopName = false;

            while (!stopName)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("What is your name? (Case Sensitive)");
                Console.Write(">> ");
                name = Console.ReadLine();

                // name check to make sure name is unique
                foreach(Core.Player.Player player in Core.Player.Player.players)
                {
                    if (name.Equals(player.Name))
                    {
                        Console.WriteLine("Name already taken!");
                        continue;
                    }
                    else
                    {
                        stopName = true;
                    }
                }        

                Core.StandardMessages.BreakApartDisplay();
                Console.ResetColor();
            }

            while (!stopClass)
            {
                Console.WriteLine("What class would you like to have?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Warrior - Damage + 30% \nRogue - Potion Effectiveness + 20% \nWizard - Magic + 30% \n>> ");
                classType = Console.ReadLine().ToLower();
                Core.StandardMessages.BreakApartDisplay();
                Console.ResetColor();

                if (classType == "warrior")
                {
                    attack = 15;
                    stopClass = true;
                }
                else if (classType == "rogue")
                {
                    attack = 10;
                    stopClass = true;
                }
                else if (classType == "wizard")
                {
                    attack = 5;
                    stopClass = true;
                }
                else
                {
                    Console.WriteLine("Not a valid class");
                }

            }

            while (!stopRace)
            {
                Console.WriteLine("What race would you like to be?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Human \nDragonborn \nElf\n>> ");
                race = Console.ReadLine().ToLower();

                Core.StandardMessages.BreakApartDisplay();
                Console.ResetColor();

                if (race == "human")
                {
                    hp = 120;
                    evasion = 15;
                    stopRace = true;
                }
                else if (race == "dragonborn")
                {
                    hp = 150;
                    evasion = 5;
                    stopRace = true;
                }
                else if (race == "elf")
                {
                    hp = 100;
                    evasion = 25;
                    stopRace = true;
                }
                else
                {
                    Console.WriteLine("Not a valid Choice!");
                }
            }

            while (stopPassword == false)
            {
                Console.Write("Please create a password \nYour Password must contain a lowercase letter, an uppercase letter, and a special character\nAnd must also contain 6 characters \n>> ");
                password = Console.ReadLine();

                // First checks if any index/subscript of the password conatains the specified characters, if it does IndexofAny will return the index which will be higher than -1, if it doesn't it fails
                // Then checks if any character in the string is an uppercase and then lowercase character using an anonymous function and local variable the will return a value or no value which is seen as true or false
                // Then finally checks length.

                if ((password.IndexOfAny("!@#$%^&*?_~-".ToCharArray()) != -1) && password.Any(c => char.IsUpper(c)) && password.Any(c => char.IsLower(c)) && password.Length > 5)
                {
                    stopPassword = true;
                }
                else
                {
                    Console.WriteLine("Your password did not meet requirements.");
                    Core.StandardMessages.BreakApartDisplay();
                }

            }
            Core.Player.Player._player = new Core.Player.Player(name, password, classType, race, hp, evasion, attack, 0);
        }
    }
}

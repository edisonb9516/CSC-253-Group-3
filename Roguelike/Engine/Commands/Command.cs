using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public class Command
    {
        public static void CommandSelection(string input)
        {
            switch (input)
            {
                case "rooms":
                    Core.StandardMessages.ViewAfterChoice("Rooms");
                    foreach (Core.Location.Room room in Core.Location.Room.rooms)
                    {
                        Console.WriteLine(room.Name);
                    }
                    Console.WriteLine("_______________________________________________");

                    break;

                case "weapons":
                    Core.StandardMessages.ViewAfterChoice("Weapons");
                    foreach (Core.Items_Inventory.Weapon weapon in Core.Items_Inventory.Weapon.weapons)
                    {
                        Console.WriteLine(weapon.Name);
                    }
                    break;

                case "potions":
                    Core.StandardMessages.ViewAfterChoice("Potions");
                    foreach (Core.Items_Inventory.Potion potions in Core.Items_Inventory.Potion.potions)
                    {
                        Console.WriteLine(potions.Name);
                    }
                    break;

                case "treasure":
                    Core.StandardMessages.ViewAfterChoice("Treasure");
                    foreach (Core.Items_Inventory.Treasure treasure in Core.Items_Inventory.Treasure.treasures)
                    {
                        Console.WriteLine(treasure.Name);
                    }
                    break;

                case "items":
                    Core.StandardMessages.ViewAfterChoice("Items");
                    foreach (Core.Items_Inventory.Items item in Core.Items_Inventory.Items.items)
                    {
                        Console.WriteLine(item.Name);
                    }
                    break;

                case "enemies":
                    Core.StandardMessages.ViewAfterChoice("Enemies");
                    foreach (Core.NPC.Mob enemy in Core.NPC.Mob.mobs)
                    {
                        Console.WriteLine(enemy.Name);
                    }
                    break;

                case "north":
                case "n":
                    Movement.Move("north");
                    Core.StandardMessages.DisplayLocation();
                    if (Movement.cantGo == true)
                    {
                        Console.WriteLine("You can't go north");
                    }
                    break;
                case "south":
                case "s":
                    Movement.Move("south");
                    Core.StandardMessages.DisplayLocation();
                    if (Movement.cantGo == true)
                    {
                        Console.WriteLine("You can't go south");
                    }
                    break;
                case "east":
                case "e":
                    Movement.Move("east");
                    Core.StandardMessages.DisplayLocation();
                    if (Movement.cantGo == true)
                    {
                        Console.WriteLine("You can't go east");
                    }
                    break;
                case "west":
                case "w":
                    Movement.Move("west");
                    Core.StandardMessages.DisplayLocation();
                    if (Movement.cantGo == true)
                    {
                        Console.WriteLine("You can't go west");
                    }
                    break;
                case "attack":
                    // TODO  actual damage
                    int damage = Attack.AttackDamage();
                    Console.WriteLine($"Damage Dealt to enemy : {damage}");
                    break;
                case "help":
                    Help.DisplayHelpInfo();
                    break;
                case "exit":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Exiting!");
                    exit = true;
                    break;
                case "location":
                    Core.StandardMessages.DisplayLocation();
                    break;
                default:
                    Core.StandardMessages.ChoiceError();
                    break;
            }
        }

        public static string CheckInput(ref string input)
        {
            // make input case insensitive
            input = input.ToLower();

            return input;
        }

        public static bool exit = false;
    }
}

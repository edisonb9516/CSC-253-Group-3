using Engine.Core.NPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Combat
{
    public static class Combat
    {
        // TODO change sentences to reflect type of damage when displaying e.g. blunt pierce slash. Use the _player.Weapon.DamageType to display
        // this will take into account player attack, player weapon attack, hp, and evasion as well as mob attack, hp, and evasion
        internal static void Fight(Mob enemy, Player.Player player)
        {
            Random rand = new Random();
            while (player.CurrentHP > 0 && enemy.CurrentHP > 0)
            {
                int playerDamage = player.Attack + player.Weapon.Damage + rand.Next(9) + 1;
                int enemyDamage = enemy.Damage + rand.Next(9) + 1;

                Console.WriteLine($"You attack with {player.Weapon.Name} for : {playerDamage}");

                if (enemy.Evasion <= rand.Next(99) + 1)    // TODO add evasion modifiers to weapons and check them here modifying player.evasion
                {
                    Console.WriteLine($"You hit {enemy.Name} for {playerDamage}.");

                    enemy.CurrentHP -= playerDamage;

                    Console.WriteLine($"{enemy.Name} has {enemy.CurrentHP} HP left");

                    if (enemy.CurrentHP <= 0)
                    {
                        Console.WriteLine($"{enemy.Name} has been killed!");
                        player.Gold += enemy.Gold;
                        Console.WriteLine($"You have {player.Gold} gold!");
                        StandardMessages.DisplayLocation();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Your attack missed!");
                }

                if (player.Evasion <= rand.Next(99) + 1)
                {
                    Console.WriteLine($"The {enemy.Name} hit you for {enemyDamage} HP!");

                    player.CurrentHP -= enemyDamage;

                    Console.WriteLine($"You have {player.CurrentHP} HP left");

                    if (player.CurrentHP <= 0)
                    {
                        Console.WriteLine("You have died.... \nGoing back to the start....");
                        // Reset gold and hp then move back to entrance
                        player.Gold = 0;
                        player.CurrentHP = player.Hp;
                        Commands.Movement.MoveRooms(Location.Room.rooms[0]);
                        StandardMessages.DisplayLocation();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The Enemy missed its attack!");
                }
            }
        }
    }
}

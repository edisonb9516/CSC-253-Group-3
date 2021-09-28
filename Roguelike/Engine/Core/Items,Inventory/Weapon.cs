using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Weapon
    {
        // List
        public static List<Weapon> weapons = new List<Weapon>();
        // TODO add evasion modifier as a parameter some weapons like daggers and bows have a high evasion modifiers while others might have zero like claymore. This should be an integer that will add
        // to player evasion which will then be calculated in combat

        public Weapon(int id, string name, string decription, int damage, int price)
        {
            Id = id;
            Name = name;
            Description = decription;
            Damage = damage;
            Price = price;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Damage { get; }
        public int Price { get; }
    }
}

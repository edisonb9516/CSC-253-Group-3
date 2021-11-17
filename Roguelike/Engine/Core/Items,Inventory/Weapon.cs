using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Weapon : IInventory
    {
        // List
        public static List<Weapon> weapons = new List<Weapon>();
        // TODO add evasion modifier as a parameter some weapons like daggers and bows have a high evasion modifiers while others might have zero like claymore. This should be an integer that will add
        // to player evasion which will then be calculated in combat

        public Weapon(int id, string name, string description, int damage, int price, string damageType)
        {
            Id = id;
            Name = name;
            Description = description;
            Damage = damage;
            Price = price;
            DamageType = damageType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
        public int Price { get; set; }
        public string DamageType { get; set; }

        public Weapon()
        {

        }
    }
}

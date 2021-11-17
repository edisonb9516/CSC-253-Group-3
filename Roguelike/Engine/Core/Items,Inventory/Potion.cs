using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Potion : IInventory
    {
        // TODO Add price property
        // List
        public static List<Potion> potions = new List<Potion>();

        public Potion(int id, string name, string description, int value, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
            Price = price;
        }
        //public int HealthPotion { get; set; }
        //public int ManaPotion { get; set; }
        //public int IncDamagePotion { get; set; }
        //public int IncStaminaPotion { get; set; }
        //public int IncEvadePotion { get; set; }
        //public int IncLuckPotion { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Value{ get; set; }
        public int Price { get; set; }

        public Potion()
        {

        }
    }
}

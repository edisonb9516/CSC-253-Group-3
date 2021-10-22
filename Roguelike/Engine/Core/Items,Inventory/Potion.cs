using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Potion
    {
        // TODO Add price property
        // List
        public static List<Potion> potions = new List<Potion>();

        public Potion(int id, string name, string description, int value)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
        }
        //public int HealthPotion { get; set; }
        //public int ManaPotion { get; set; }
        //public int IncDamagePotion { get; set; }
        //public int IncStaminaPotion { get; set; }
        //public int IncEvadePotion { get; set; }
        //public int IncLuckPotion { get; set; }
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Value{ get; }

        public Potion()
        {

        }
    }
}

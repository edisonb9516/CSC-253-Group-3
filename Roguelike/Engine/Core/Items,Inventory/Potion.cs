using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Potion
    {
        // List
        public static List<Potion> potions = new List<Potion>();
        // TODO potions
        public int HealthPotion { get; set; }
        public int ManaPotion { get; set; }
        public int IncDamagePotion { get; set; }
        public int IncStaminaPotion { get; set; }
        public int IncEvadePotion { get; set; }
        public int IncLuckPotion { get; set; }
    }
}

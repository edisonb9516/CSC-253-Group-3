using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Treasure
    {
        // List
        public static List<Treasure> treasures = new List<Treasure>();

        public Treasure(int id, string name, string description, int value)
        {
            Id = id;
            Name = name;
            Description = description;
            Value = value;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Value { get; }


        // TODO add treasure
        //public int Gold { get; set; }
        //public int Silver { get; set; }
        //public string SilverBroach { get; set; }
        //public string MusicBox { get; set; }
        //public string CrystalOrb { get; set; }
        //public string Diamond { get; set; }
        //public int StaminaRing { get; set; }
        //public int ManaRing { get; set; }
        //public int DamageRing { get; set; }
        //public int EvadeRing { get; set; }
    }
}

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
        // TODO Weapons
        public string BroadSword { get; set; };
        public string Claymore { get; set; };
        public string MorningStar { get; set; };
        public string GoldenStaff { get; set; };
        public string DragonslayerBow { get; set; };
        public string Daggers { get; set; };
    }
}

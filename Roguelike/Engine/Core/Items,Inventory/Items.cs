using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Items : IInventory
    {
        // List
        // TODO make this the parent class for all other items in the game then make them inherit from this class
        public static List<Items> items = new List<Items>();

        public Items(int id, string name, string description, int price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Items()
        {

        }
    }
}

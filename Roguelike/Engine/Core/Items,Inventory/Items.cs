using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public class Items
    {
        // List
        public static List<Items> items = new List<Items>();

        public Items(int id, string name, string description, int price, int quest)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Price { get; }
        public int Quest { get; }
    }
}

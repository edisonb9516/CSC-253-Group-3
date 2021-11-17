using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Items_Inventory
{
    public interface IInventory
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        int Price { get; set; }
    }
}

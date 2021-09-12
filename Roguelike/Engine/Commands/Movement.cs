using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public class Movement
    {
        // TODO Figure out movement for moving nsew between rooms, maybe room.northExit > 0 as the condition then handle movement with the next room id?
        public static string Move(string direction)
        {
            switch (direction)
            {
                case "north":
                    return "We Tried";
                default:
                    return "Something went wrong";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.NPC
{
    public class Mob
    {
        // TODO extra list of mobs to use for fighting which will be added to when you enter a room and need to copy a mob to fight from the original mob list
        public static List<Mob> mobs = new List<Mob>();

        public Mob(int id, string name, string description, int hp, int damage, int gold, int evasion)
        {
            Id = id;
            Name = name;
            Description = description;
            Hp = hp;
            Damage = damage;
            Gold = gold;
            Evasion = evasion;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Hp { get; }
        public int Damage { get; }
        public int Gold { get; }
        public int Evasion { get; }


    }
}


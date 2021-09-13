using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.NPC
{
    public class Mob
    {
        // List
        public static List<Mob> mobs = new List<Mob>();

        public Mob(int id, string name, string description, int hp, int damage)
        {
            Id = id;
            Name = name;
            Description = description;
            Hp = hp;
            Damage = damage;
        }

        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Hp { get; }
        public int Damage { get; }

        // TODO add enemy class then read from text file and create by passing input from text to here. Done in the listbuilder class

    }
}


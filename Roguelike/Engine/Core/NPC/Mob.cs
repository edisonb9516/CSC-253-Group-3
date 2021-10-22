using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.NPC
{
    public class Mob
    {
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

        // use this to generate mobs from already existing mobs in the refence list for battles
        public Mob(Mob monster)
        {
            this.Id = monster.Id;
            this.Name = monster.Name;
            this.Description = monster.Description;
            this.Hp = monster.Hp;
            this.Damage = monster.Damage;
            this.Gold = monster.Gold;
            this.Evasion = monster.Evasion;

            // set this to HP to start off then modify it in list or Room object
            CurrentHP = monster.Hp;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; }
        public int Gold { get; set; }
        public int Evasion { get; set; }
        public int CurrentHP { get; set; }

        public Mob()
        {

        }
    }
}


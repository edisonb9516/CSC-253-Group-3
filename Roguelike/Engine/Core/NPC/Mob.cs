using Engine.Core.ParentCharacterClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.NPC
{
    public class Mob : ParentClassForCharacters
    {
        public static List<Mob> mobs = new List<Mob>();

        public Mob(int id, string name, string description, int hp, int attack, int gold, int evasion) : base(name, hp, attack, evasion, gold)
        {
            Id = id;
            Description = description;
        }

        // use this to generate mobs from already existing mobs in the refence list for battles
        public Mob(Mob monster, string name, int hp, int attack, int evasion, int gold) : base(name, hp, attack, evasion, gold)
        {
            this.Id = monster.Id;
            this.Name = monster.Name;
            this.Description = monster.Description;
            this.Hp = monster.Hp;
            this.Attack = monster.Attack;
            this.Gold = monster.Gold;
            this.Evasion = monster.Evasion;

            // set this to HP to start off then modify it in list or Room object
            CurrentHP = monster.Hp;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int CurrentHP { get; set; }

        public Mob(string name, int hp, int attack, int evasion, int gold) : base(name, hp, attack, evasion, gold)
        {

        }
    }
}


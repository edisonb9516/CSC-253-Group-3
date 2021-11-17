using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.ParentCharacterClass
{
    public abstract class ParentClassForCharacters
    {
        //parent class to create characters and mobs from
        public ParentClassForCharacters(string name, int hp, int attack, int evasion, int gold)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            Evasion = evasion;
            Gold = gold;
           
        }

        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Evasion { get; set; }
        public int Gold { get; set; }



    }
}

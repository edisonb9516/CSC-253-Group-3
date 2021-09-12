using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Commands
{
    public class Attack
    {
        // TODO actual combat rolls
        public static int AttackDamage()
        {
            int damage;
            var rand = new Random();
            damage = rand.Next(21);

            return damage;
        }
    }
}

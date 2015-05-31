using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class Attack : IAbility
    {
        private Character owner;

        public Attack( ref Character own)
        {
            owner = own;
        }
        public string ability(ref Party party)
        {
            string response = "";
            owner.Stance = 1.0;
            Character target = owner.aim(ref party);
            int oldHP = target.HP;
            double newHP = oldHP - owner.Str * target.Stance;
            target.HP = ((int)newHP);

            response += owner.Name + " attacked " + target.Name + ".\n";
            response += target.Name + " lost " + owner.Str + " HP and now has " + target.HP + " left.";
            return response;
        }

        public string getName()
        {
            return "Attack";
        }
    }
}

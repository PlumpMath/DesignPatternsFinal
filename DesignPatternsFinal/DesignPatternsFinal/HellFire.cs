using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class HellFire : IAbility
    {
        public String getName()
        {
            return "Hell Fire";
        }
        public String ability(Party party)
        {
            String response = "";

            response += "Hades sends out a spray of fire!";

            foreach (Character enemy in party)
            {
                int oldHP = enemy.HP;
                if (enemy.HP > (enemy.maxHP / 2))
                {
                    double damage = (30 - enemy.Wis) * enemy.Stance;
                    double newHP = oldHP - damage;
                    enemy.HP = ((int)newHP);

                    response += enemy.Name + " was hit by the fire.\n";
                    response += enemy.Name + " lost " + enemy.Str + " HP and now has\n";
                    response += enemy.HP + " left.\n";
                }
            }
            return response;
        }
    }
}

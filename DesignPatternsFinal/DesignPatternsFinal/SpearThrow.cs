using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class SpearThrow : IAbility
    {

        public String ability(Party party)
        {
            Character target = party.ElementAt(0);
            target.HP = target.HP / 4 ;
            String response = "Ares  struck " + target.Name + " with a spear.\n";
            response += target.Name + "is almost dead and has " + target.HP + " HP left.\n";
            return response;
        }

        public String getName()
        {
            return "Spear Throw";
        }

    }
}

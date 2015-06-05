using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class TeamHeal :IAbility
    {
        
        public String ability(Party party)
        {
            String response = "Aphrodite is healing the team...\n";
            foreach( Character ally in party )
            {
                if( ally.HP != ally.maxHP )
                {
                    ally.HP = (ally.maxHP - ally.HP) / 2 ;
                    response += ally.Name + " was healed and now has " + ally.HP + " HP.\n" ;
                }
            }
            return response;
        }

        public String getName()
        {
            return "Team Heal";
        }

    }
}

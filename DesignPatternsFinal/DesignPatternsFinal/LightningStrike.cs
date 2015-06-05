using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class LightningStrike : IAbility
    {

        public String ability(Party party)
        {
            Character target = party.ElementAt(0);
            foreach( Character it in party )
            {
                if( it.HP > target.HP )
                {
                    target = it;
                }
            }
            target.HP = target.HP / 2 ;
            String response = "Zeus  struck " + target.Name + " with lightning!\n";
            response += target.Name + "'s HP was cut in half to " + target.HP + ".\n";
            return response;
        }

        public String getName()
        {
            return "Lightning Strike";
        }

    }
}

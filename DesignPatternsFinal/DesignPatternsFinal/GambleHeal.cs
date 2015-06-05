using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class GambleHeal : IAbility
    {

        public String ability(Party party)
        {
            Random rand = new Random();
            double choice = rand.NextDouble();

            String response = "";

            if( choice > .45 )
            {
                Character target = party.ElementAt(0);
                foreach( Character it in party )
                {
                    if( (it.maxHP - it.HP) > (target.maxHP - target.HP) )
                    {
                        target = it;
                    }
                }
                target.HP = target.maxHP;
                response += target.Name + " was healed and now has full HP.";
            }
            else
            {
                response += "The gamble failed. No healing was done.";
            }
            
            return response;
        }

        public String getName()
        {
            return "Gamble Heal";
        }

    }
}

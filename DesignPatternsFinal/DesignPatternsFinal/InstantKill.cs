using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class InstantKill : IAbility
    {

        public String ability(Party party)
        {
            Random rand = new Random();
            double choice = rand.NextDouble();

            String response = "";

            if (choice > .15)
            {
                Character target = party.ElementAt(0);
                foreach (Character it in party)
                {
                    if ((it.maxHP - it.HP) < (target.maxHP - target.HP))
                    {
                        target = it;
                    }
                }
                target.HP = target.maxHP;
                response += target.Name + " was killed by Nemesis.";
            }
            else
            {
                response += "Nemesis failed to get a kill.";
            }

            return response;
        }

        public String getName()
        {
            return "Instant Kill";
        }

    }
}


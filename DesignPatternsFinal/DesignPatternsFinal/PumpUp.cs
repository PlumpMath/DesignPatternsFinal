using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class PumpUp : IAbility
    {

        public String ability(Party party)
        {
            Random rand = new Random();
            double choice = rand.NextDouble();

            String response = "";
            Character target = party.ElementAt(0);

            if (choice > .70)
            {   
                foreach (Character it in party)
                {
                    if (it.Str < target.Str)
                    {
                        target = it;
                    }
                }
                target.Str ++;
                response = target.Name + " received a permanent strength increase!";
            }
            else
            {
                response = "Nike was unable to pump anyone up.";
            }
            return response;
        }

        public String getName()
        {
            return "Pump Up";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class Defend : IAbility
    {
        private Character own;
        public Defend(Character owner)
        {
            own = owner;
        }
        public string ability(ref Party party)
        {
            own.Stance = .25;
            return (own.Name + " is now defending.");
        }

        public string getName()
        {
            return "Defend";
        }
    }
}

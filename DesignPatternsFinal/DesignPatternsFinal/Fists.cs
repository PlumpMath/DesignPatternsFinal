using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Fists : Item
    {
        public Fists()
        {
            name = "Fists";
            damageMax = 7;
            damageMin = 3;
        }

        public abstract string getName();
        public abstract int getDamageMax();
        public abstract int getDamageMin();
    }
}

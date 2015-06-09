using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class LongSword : Item
    {
        public LongSword()
        {
            name = "Long Sword";
            damageMax = 15;
            damageMin = 10;
        }

        public abstract string getName();
        public abstract int getDamageMax();
        public abstract int getDamageMin();
    }
}

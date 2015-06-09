using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonStrength : Item
    {
        public poisonStrength()
        {
            name = "Poison Strength";
            poisonMax = 14;
            poisonMin = 8;
        }

        public abstract string getName();
        public abstract int getPoisonMax();
        public abstract int getPoisonMin();
    }
}

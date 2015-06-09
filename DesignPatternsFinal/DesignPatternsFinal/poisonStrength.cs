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
        }

        public string getName()
        {
            return "Poison Strength";
        }
        public int getPoisonMax()
        {
            return 14;
        }
        public int getPoisonMin()
        {
            return 8;
        }
    }
}

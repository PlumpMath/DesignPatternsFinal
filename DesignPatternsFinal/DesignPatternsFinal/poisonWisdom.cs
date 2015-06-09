using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonWisdom : Item
    {
        public poisonWisdom()
        {
        }

        public string getName()
        {
            return "Poison Wisdom";
        }
        public int getPoisonMax()
        {
            return 14;
        }
        public int getPoisonMin()
        {
            return 7;
        }
    }
}

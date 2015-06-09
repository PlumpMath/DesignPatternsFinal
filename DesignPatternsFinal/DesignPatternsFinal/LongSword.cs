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
        }

        public string getName()
        {
            return "Long Sword";
        }
        public int getDamageMax()
        {
            return 15;
        }
        public int getDamageMin()
        {
            return 10;
        }
    }
}

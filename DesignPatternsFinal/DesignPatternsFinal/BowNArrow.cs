using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class BowNArrow : Item
    {
        public BowNArrow()
        {
            name = "Bow and Arrow";
            damageMax = 25;
            damageMin = 10;
        }
    }
}

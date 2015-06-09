using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class ThrowingKnife : Item
    {
        public ThrowingKnife()
        {
            name = "Throwing Knife";
            damageMax = 10;
            damageMin = 6;
        }
    }
}

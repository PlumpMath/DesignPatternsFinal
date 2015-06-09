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
        {}

        public string getName()
        {
            return "Throwing Knife";
        }
        public int getDamageMax()
        {
            return 10;
        }
        public int getDamageMin()
        {
            return 6;
        }
    }
}

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
        }
        public string getName()
        {
            return "Bow and Arrow";
        }
        public int getDamageMax()
        {
            return 25;
        }
        public int getDamageMin()
        {
            return 10;
        }
        

    }
}

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
        }

        public string getName()
        {
            return "Fists";
        }
        public int getDamageMax()
        {
            return 7;
        }
        public int getDamageMin()
        {
            return 3;
        }
    }
}

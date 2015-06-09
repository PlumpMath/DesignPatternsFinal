using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Axe : Item
    {
        public Axe()
        {}

        public string getName()
        {
            return "Axe";
        }
        public int getDamageMax()
        {
            return 20;
        }
        public int getDamageMin()
        {
            return 5;
        }
     
    }
}

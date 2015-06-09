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
        {
            name = "Axe";
            damageMax = 20;
            damageMin = 5;
        }
    }
}

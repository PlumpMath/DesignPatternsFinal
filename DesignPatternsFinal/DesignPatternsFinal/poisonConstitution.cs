using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonConstitution : Item
    {
        public poisonConstitution()
        {
            name = "Poison Constitution";
            poisonMax = 12;
            poisonMin = 6;
        }
    }
}

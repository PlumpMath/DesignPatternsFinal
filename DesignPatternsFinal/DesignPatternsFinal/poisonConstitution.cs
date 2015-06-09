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
        { }

         public string getName()
        {
            return "Poison Constitution";
        }
        public int getPoisonMax()
        {
            return 12;
        }
        public int getPoisonMin()
        {
            return 6;
        }
    }
}

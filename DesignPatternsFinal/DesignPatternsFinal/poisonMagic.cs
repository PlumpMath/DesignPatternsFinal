using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonMagic : Item
    {
        public poisonMagic()
        {
        }

        public string getName()
        {
            return "Poison Magic";
        }
        public int getPoisonMax()
        {
            return 30;
        }
        public int getPoisonMin()
        {
            return 10;
        }
    }
}

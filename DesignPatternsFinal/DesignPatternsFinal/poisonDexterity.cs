using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonDexterity : Item
    {
        public poisonDexterity()
        {
        }

         public string getName()
        {
            return "Poison Dexterity";
        }
        public int getPoisonMax()
        {
            return 12;
        }
        public int getPoisonMin()
        {
            return 3;
        }
    }
}

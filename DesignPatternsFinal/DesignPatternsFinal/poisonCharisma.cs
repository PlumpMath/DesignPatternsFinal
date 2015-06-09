using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonCharisma : Item
    {
        public poisonCharisma()
        {
        }

         public string getName()
        {
            return "Poison Charisma";
        }
        public int getPoisonMax()
        {
            return 15;
        }
        public int getPoisonMin()
        {
            return 10;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonHP : Item
    {
        public poisonHP()
        {
        }

        public string getName()
        {
            return "Poison Health";
        }
        public int getPoisonMax()
        {
            return 30;
        }
        public int getPoisonMin()
        {
            return 1;
        }
    }
}

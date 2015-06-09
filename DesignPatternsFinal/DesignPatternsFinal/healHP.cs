using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healHP : Item
    {
        public healHP()
        {
        }

        public string getName()
        {
            return "Heal Health";
        }
        public int getHealMax()
        {
            return 40;
        }
        public int getHealMin()
        {
            return 20;
        }
    }
}

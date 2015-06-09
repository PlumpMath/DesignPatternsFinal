using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healMagic : Item
    {
        public healMagic()
        {
        }

        public string getName()
        {
            return "Heal Magic";
        }
        public int getHealMax()
        {
            return 25;
        }
        public int getHealMin()
        {
            return 5;
        }
    }
}

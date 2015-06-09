using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healWisdom : Item
    {
        public healWisdom()
        {
        }

        public string getName()
        {
            return "Heal Wisdom";
        }
        public int getHealMax()
        {
            return 15;
        }
        public int getHealMin()
        {
            return 10;
        }
    }
}

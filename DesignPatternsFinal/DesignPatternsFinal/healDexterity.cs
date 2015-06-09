using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healDexterity : Item
    {
        public healDexterity()
        {
        }

        public string getName()
        {
            return "Heal Dexterity";
        }
        public int getHealMax()
        {
            return 10;
        }
        public int getHealMin()
        {
            return 2;
        }
    }
}

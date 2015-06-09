using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healCharisma : Item
    {
        public healCharisma()
        {
        }

        public string getName()
        {
            return "Heal Charisma";
        }
        public int getHealMax()
        {
            return 15;
        }
        public int getHealMin()
        {
            return 7;
        }
    }
}

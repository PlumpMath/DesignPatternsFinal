using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healStrength : Item
    {
        public healStrength()
        {
        }

        public string getName()
        {
            return "Heal Strength";
        }
        public int getHealMax()
        {
            return 20;
        }
        public int getHealMin()
        {
            return 15;
        }
    }
}

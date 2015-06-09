using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healConstitution : Item
    {
        public healConstitution()
        {
        }

        public string getName()
        {
            return "Heal Constitution";
        }
        public int getHealMax()
        {
            return 5;
        }
        public int getHealMin()
        {
            return 1;
        }
    }
}

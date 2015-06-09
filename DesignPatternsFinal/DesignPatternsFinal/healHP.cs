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
            name = "Heal Health";
            healMax = 40;
            healMin = 20;
        }

        public abstract string getName();
        public abstract int getHealMax();
        public abstract int getHealMin();
    }
}

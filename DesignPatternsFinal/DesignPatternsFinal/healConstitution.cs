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
            name = "Heal Constitution";
            healMax = 5;
            healMin = 1;
        }

        public abstract string getName();
        public abstract int getHealMax();
        public abstract int getHealMin();
    }
}

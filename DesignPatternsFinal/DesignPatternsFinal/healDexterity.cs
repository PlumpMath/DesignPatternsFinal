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
            name = "Heal Dexterity";
            healMax = 10;
            healMin = 2;
        }
    }
}

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
            name = "Heal Charisma";
            healMax = 15;
            healMin = 7;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonCharisma : Item
    {
        public poisonCharisma()
        {
            name = "Poison Charisma";
            poisonMax = 15;
            poisonMin = 10;
        }

        public abstract string getName();
        public abstract int getPoisonMax();
        public abstract int getPoisonMin();

    }
}

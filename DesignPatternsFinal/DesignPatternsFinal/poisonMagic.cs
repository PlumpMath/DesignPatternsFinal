﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonMagic : Item
    {
        public poisonMagic()
        {
            name = "Poison Magic";
            poisonMax = 30;
            poisonMin = 10;
        }

        public abstract string getName();
        public abstract int getPoisonMax();
        public abstract int getPoisonMin();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Javelin: Item
    {
        public Javelin()
        {
            name = "Javelin";
            damageMax = 30;
            damageMin = 1;
        }

        public abstract string getName();
        public abstract int getDamageMax();
        public abstract int getDamageMin();
    }
}

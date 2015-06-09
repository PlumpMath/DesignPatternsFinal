﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healMagic : Item
    {
        public healMagic()
        {
            name = "Heal Magic";
            healMax = 25;
            healMin = 5;
        }

        public abstract string getName();
        public abstract int getHealMax();
        public abstract int getHealMin();
    }
}

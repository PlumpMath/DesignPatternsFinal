﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healWisdom : Item
    {
        public healWisdom()
        {
            name = "Wisdom Heal";
            healMax = 15;
            healMin = 10;
        }

        public abstract string getName();
        public abstract int getHealMax();
        public abstract int getHealMin();
    }
}

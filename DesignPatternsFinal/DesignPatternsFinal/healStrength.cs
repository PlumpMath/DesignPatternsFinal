﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class healStrength : Item
    {
        public healStrength()
        {
            name = "Heal Strength";
            healMax = 20;
            healMin = 15;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonDexterity : Item
    {
        public poisonDexterity()
        {
            name = "Poison Dexterity";
            poisonMax = 12;
            poisonMin = 3;
        }
    }
}
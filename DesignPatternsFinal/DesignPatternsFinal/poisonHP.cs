﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class poisonHP : Item
    {
        public poisonHP()
        {
            name = "Poison Health";
            poisonMax = 30;
            poisonMin = 1;
        }
    }
}
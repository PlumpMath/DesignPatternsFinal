using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Cerberus : Beast
    {
        public Cerberus()
        {
            Name = "Cerberus";
            HP = 1000;
            maxHP = 1000;
            Str = 20;
            Dex = 20;
            Mag = 12;
            Con = 18;
            Wis = 13;
            Cha = 10;
            Stance = 1.0;
        }
    }
}


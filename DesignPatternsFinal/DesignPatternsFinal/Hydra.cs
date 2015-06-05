using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Hydra : Beast
    {
        public Hydra()
        {
            Name = "Hydra";
            HP = 14;
            maxHP = 14;
            Str = 7;
            Dex = 20;
            Mag = 18;
            Con = 11;
            Wis = 16;
            Cha = 15;
            Stance = 1.0;
        }
    }
}

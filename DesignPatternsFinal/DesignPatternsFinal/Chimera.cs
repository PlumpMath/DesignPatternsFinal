using System;

namespace DesignPatternsFinal
{
    class Chimera : Beast
    {
        public Chimera()
        {
            Name = "Chimera";
            HP = 120;
            maxHP = 120;
            Str = 10;
            Dex = 16;
            Mag = 18;
            Con = 16;
            Wis = 16;
            Cha = 12;
            Stance = 1.0;
        }
    }
}

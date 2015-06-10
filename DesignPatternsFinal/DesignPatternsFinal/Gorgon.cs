using System;

namespace DesignPatternsFinal
{
    class Gorgon : Beast
    {
        public Gorgon() : base() 
        {
            Name = "Gorgon";
            HP = 220;
            maxHP = 220;
            Str = 8;
            Dex = 18;
            Mag = 20;
            Con = 14;
            Wis = 14;
            Cha = 16;
            Stance = 1.0;
        }
    }
}
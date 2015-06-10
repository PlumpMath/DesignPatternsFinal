using System;

namespace DesignPatternsFinal
{
    class Siren : Beast
    {
        public Siren() : base() 
        {
            Name = "Siren";
            HP = 110;
            maxHP = 110;
            Str = 7;
            Dex = 18;
            Mag = 20;
            Con = 12;
            Wis = 14;
            Cha = 18;
            Stance = 1.0;
        }
    }
}
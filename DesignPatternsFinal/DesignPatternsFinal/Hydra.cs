using System;

namespace DesignPatternsFinal
{
    class Hydra : Beast
    {
        public Hydra() : base() 
        {
            Name = "Hydra";
            HP = 200;
            maxHP = 200;
            Str = 9;
            Dex = 20;
            Mag = 18;
            Con = 11;
            Wis = 16;
            Cha = 15;
            Stance = 1.0;
        }
    }
}
using System;

namespace DesignPatternsFinal
{
    class Minotaur : Beast
    {
        public Minotaur()
        {
            Name = "Minotaur";
            HP = 450;
            maxHP = 450;
            Str = 11;
            Dex = 15;
            Mag = 14;
            Con = 16;
            Wis = 18;
            Cha = 12;
            Stance = 1.0;
        }
    }
}
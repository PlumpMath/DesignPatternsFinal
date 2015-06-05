﻿using System;

namespace DesignPatternsFinal
{
    public class Hades : God
    {
        public Hades()
        {
            Name = "Hades";
            HP = 13;
            maxHP = 13;
            Str = 14;
            Dex = 16;
            Mag = 19;
            Con = 10;
            Wis = 12;
            Cha = 19;
            Stance = 1.0;

            //starting armor
            //starting weapon
            special = new HellFire();
        }

        override
        public void specialAbility(Party team, Party enemies)
        {
            this.special.ability(enemies);
            this.Stance = 1.0;
        }
    }
}
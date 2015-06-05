﻿using System;

namespace DesignPatternsFinal
{
    public class Aphrodite : God
    {
        public Aphrodite()
        {
            Name = "Aphrodite";
            HP = 10;
            maxHP = 10;
            Str = 9;
            Dex = 12;
            Mag = 22;
            Con = 10;
            Wis = 20;
            Cha = 16;
            Stance = 1.0;

            //starting armor
            //starting weapon
            special = new TeamHeal() ;
        }

        override
        public void specialAbility(Party team, Party enemies)
        {
            this.special.ability(team);
            this.Stance = 1.0;
        }
    }
}
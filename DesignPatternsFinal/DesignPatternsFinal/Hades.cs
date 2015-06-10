using System;

namespace DesignPatternsFinal
{
    public class Hades : God
    {
        public Hades() : base() 
        {
            Name = "Hades";
            HP = 130;
            maxHP = 130;
            Str = 14;
            Dex = 16;
            Mag = 19;
            Con = 10;
            Wis = 12;
            Cha = 19;
            Stance = 1.0;

            //starting armor
            //starting weapon
            //special = new HellFire();
            moves.Add(new HellFire());
        }
        /*
        override
        public void specialAbility(Party team, Party enemies)
        {
            this.special.ability(enemies);
            this.Stance = 1.0;
        }*/
    }
}
using System;

namespace DesignPatternsFinal
{
    public class Ares : God
    {
        public Ares() : base() 
        {
            Name = "Ares";
            HP = 185;
            maxHP = 185;
            Str = 20;
            Dex = 13;
            Mag = 9;
            Con = 16;
            Wis = 12;
            Cha = 13;
            Stance = 1.0;

            //starting armor
            //starting weapon
            //special = new SpearThrow();
            moves.Add(new SpearThrow());
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
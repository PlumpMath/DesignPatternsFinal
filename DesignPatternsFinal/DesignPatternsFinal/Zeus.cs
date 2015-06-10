using System;

namespace DesignPatternsFinal
{
    public class Zeus : God
    {
        public Zeus() : base() 
        {
            Name = "Zeus";
            HP = 120;
            maxHP = 120;
            Str = 16;
            Dex = 12;
            Mag = 14;
            Con = 14;
            Wis = 17;
            Cha = 18;
            Stance = 1.0;

            //starting armor
            //starting weapon
            //special = new LightningStrike();
            moves.Add(new LightningStrike());
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
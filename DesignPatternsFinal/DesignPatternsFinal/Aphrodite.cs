using System;

namespace DesignPatternsFinal
{
    public class Aphrodite : God
    {
        public Aphrodite() : base() 
        {
            Name = "Aphrodite";
            HP = 105;
            maxHP = 105;
            Str = 9;
            Dex = 12;
            Mag = 22;
            Con = 10;
            Wis = 20;
            Cha = 16;
            Stance = 1.0;

            //starting armor
            //starting weapon
            //special = new TeamHeal() ;
            moves.Add(new TeamHeal());
        }
        /*
        override
        public void specialAbility(Party team, Party enemies)
        {
            this.special.ability(team);
            this.Stance = 1.0;
        }*/
    }
}
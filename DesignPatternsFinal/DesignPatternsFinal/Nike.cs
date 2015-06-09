using System;

namespace DesignPatternsFinal
{
    public class Nike : God
    {
        public Nike()
        {
            Name = "Nike";
            HP = 150;
            maxHP = 150;
            Str = 14;
            Dex = 20;
            Mag = 13;
            Con = 14;
            Wis = 16;
            Cha = 19;
            Stance = 1.0;

            //starting armor
            //starting weapon
            //special = new PumpUp();
            moves.Add(new PumpUp());
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
using System;

namespace DesignPatternsFinal
{
    public class Tyche : God
    {
        public Tyche() : base() 
        {
            Name = "Tyche";
            HP = 110;
            maxHP = 110;
            Str = 13;
            Dex = 16;
            Mag = 16;
            Con = 13;
            Wis = 20;
            Cha = 18;
            Stance = 1.0;

            //starting armor
            //starting weapon
            //special = new GambleHeal();
            moves.Add(new GambleHeal());
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
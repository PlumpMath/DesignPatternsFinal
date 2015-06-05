using System;

namespace DesignPatternsFinal
{
    public class Poseidon : God
    {
        public Poseidon()
        {
            Name="Poseidon";
            HP = 11;
            maxHP = 11;
            Str = 12;
            Dex = 14;
            Mag = 18;
            Con = 11;
            Wis = 16;
            Cha = 15;
            Stance = 1.0;

            //starting armor
            //starting weapon
            special = new GreatWave(); 
        }

        override
        public void specialAbility(Party team, Party enemies)
        {
            this.special.ability(enemies);
            this.Stance = 1.0;
         }
    }
}
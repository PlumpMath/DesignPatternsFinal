using System;

namespace DesignPatternsFinal
{
    public class Nemesis : God
    {
        public Nemesis()
        {
            Name = "Nemesis";
            HP = 145;
            maxHP = 145;
            Str = 17;
            Dex = 20;
            Mag = 16;
            Con = 15;
            Wis = 13;
            Cha = 12;
            Stance = 1.0;

            //starting armor
            //starting weapon
            special = new InstantKill();
        }

        override
        public void specialAbility(Party team, Party enemies)
        {
            this.special.ability(enemies);
            this.Stance = 1.0;
        }
    }
}
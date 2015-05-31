using System;

namespace DesignPatternsFinal
{
    public class Poseidon : God
    {
        //private IAbility specialPower;

        public Poseidon()
        {
            //setName("Poseidon");
            //setHp(11);
            //setStrength(12);
            //setDexterity(14);
            //setMagic(18);
            //setConstitution(11);
            //setWisdom(16);
            //setCharisma(15);
            //setStanceMultiplier(1);

            Name="Poseidon";
            HP = 11;
            Str = 12;
            Dex = 14;
            Mag = 18;
            Con = 11;
            Wis = 16;
            Cha = 15;
            Stance = 1.0;

            //starting armor
            //starting weapon
            special = new GreatWave(); ;
        }

        override
        public void specialAbility(Party team, Party enemies)
        {
            //call special ability instance
            this.special.ability(ref enemies);
            this.Stance = 1.0;
            //this.setStanceMultiplier(1.0);
        }
    }
}
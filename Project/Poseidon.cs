using System;

namespace DesignPatternsProject
{
    public class Poseidon : God
    {
        public Poseidon()
        {
            setName( "Poseidon" );
            setHp( 11 );
            setStrength( 12 );
            setDexterity( 14 );
            setMagic( 18 );
            setConstitution( 11 );
            setWisdom( 16 );
            setCharisma( 15 );
            setStanceMultiplier(1);

            //starting armor
            //starting weapon
            //special ablilty
        }

        override
        public void specialAbility(Party team, Party enemies)
        {
            //call special ability instance
            this.setStanceMultiplier(1.0);
        }

    }
}
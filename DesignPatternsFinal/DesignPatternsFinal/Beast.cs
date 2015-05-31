using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    abstract class Beast : Character
    {
        public Beast()
        {
            //setName( "Hydra" );
            //setHp( 14 );
            //setStrength( 7 );
            //setDexterity( 20 );
            //setMagic( 18 );
            //setConstitution( 11 );
            //setWisdom( 16 );
            //setCharisma( 15 );
            //setStanceMultiplier(1);

            //starting armor
            //starting weapon
        }

        override
        public String turn(ref Party team, ref Party enemies)
        {
            Random rand = new Random();
            double choice = rand.NextDouble();
            if (choice > .75)
                return this.defend();
            else
                return this.attack(enemies);
        }

        override
        public Character aim(ref Party enemy)
        {
            Random rand = new Random();
            int choice = rand.Next(enemy.size());
            return enemy.getCharacter(choice);
        }
        /*Object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }*/
    }
}

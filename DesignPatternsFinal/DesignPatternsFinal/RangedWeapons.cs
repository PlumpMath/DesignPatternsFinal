using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemsProject
{
    class RangedWeapons : IWeaponBehavior
    {
        private int damageMax;
        private int damageMin;
        public RangedWeapons()
        {}

        public int getDamageMin()
        {
            return damageMin;
        }

        public int getDamageMax()
        {
            return damageMax;
        }

        public void weapon()
        {
            Console.WriteLine("Choose a ranged weapon: ");
            Console.WriteLine("1) Bow and Arrow");
            Console.WriteLine("2) Staff");
            Console.WriteLine("3) Javelin");
            Console.WriteLine("4) Throwing Knife");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1: BowNArrow();
                        break;
                    case 2: staff();
                        break;
                    case 3: javelin();
                        break;
                    case 4: throwingKnife();
                        break;
                    default: fists();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a number corresponding to the weapon of choice.");
                weapon();
            }

        }

        public void BowNArrow()
        {
            Console.WriteLine("Your hero is now using the Bow and Arrow!");
            damageMax = 25;
            damageMin = 10;
        }

        public void staff()
        {
            Console.WriteLine("Your hero is now using the Staff!");
            damageMax = 20;
            damageMin = 5;
        }

        public void javelin()
        {
            Console.WriteLine("Your hero is now using the Javelin!");
            damageMax = 30;
            damageMin = 1;
        }
        
        public void throwingKnife()
        {
            Console.WriteLine("Your hero is now using the Throwing Knives!");
            damageMax = 10;
            damageMin = 6;
        }

        public void fists()
        {
            Console.WriteLine("Your hero is now using their fists!");
            damageMax = 7;
            damageMin = 3;

        }
    }
}

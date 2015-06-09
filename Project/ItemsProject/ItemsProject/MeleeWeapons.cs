using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemsProject
{
    class MeleeWeapons : IWeaponBehavior
    {
        private int damageMin;
        private int damageMax;
        public MeleeWeapons()
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
            Console.WriteLine("Choose a melee weapon: ");
            Console.WriteLine("1) Mace");
            Console.WriteLine("2) Long Sword");
            Console.WriteLine("3) Dagger");
            Console.WriteLine("4) Axe");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: mace();
                        break;
                    case 2: longSword();
                        break;
                    case 3: dagger();
                        break;
                    case 4: axe();
                        break;
                    default: fists();
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter a number corresponding to the weapon of choice.");
                weapon();
            }
        }

        public void mace()
        {
            Console.WriteLine("Your hero is now using the mace!");
            damageMax = 10;
            damageMin = 5;
        }

        public void longSword()
        {
            Console.WriteLine("Your hero is now using the Long Sword!");
            damageMax = 15;
            damageMin = 10;
        }

        public void dagger()
        {
            Console.WriteLine("Your hero is now using the Dagger!");
            damageMax = 5;
            damageMin = 1;
        }

        public void axe()
        {
            Console.WriteLine("Your hero is now using the Axe!");
            damageMax = 20;
            damageMin = 5;
        }

        public void fists()
        {
            Console.WriteLine("Your hero is now using their fists!");
            damageMax = 7;
            damageMin = 3;
        }
    }
}

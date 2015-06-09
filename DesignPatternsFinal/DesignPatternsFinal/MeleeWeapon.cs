using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class MeleeWeapon : IWeaponBehavior
    {
        private int damageMin;
        private int damageMax;
        public MeleeWeapon()
        {}

        public int getDamageMin()
        {
            return damageMin;
        }

        public int getDamageMax()
        {
            return damageMax;
        }

        public string weapon()
        {
            string desc = "";
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
                    case 1: desc = mace();
                        return desc;
                    case 2: desc = longSword();
                        return desc;
                    case 3: desc = dagger();
                        return desc;
                    case 4: desc = axe();
                        return desc;
                    default: desc = fists();
                        return desc;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please enter a number corresponding to the weapon of choice.");
                weapon();
            }
            return desc;

        }

        public string mace()
        {
            damageMax = 10;
            damageMin = 5;
            string desc = "Your hero is now using the Mace!";
            return desc;
        }

        public string longSword()
        {
            damageMax = 15;
            damageMin = 10;
            string desc = "Your hero is now using the Long Sword!";
            return desc;
        }

        public string dagger()
        {
            damageMax = 5;
            damageMin = 1;
            string desc = "Your hero is now using the Dagger!";
            return desc;
        }

        public string axe()
        {
            damageMax = 20;
            damageMin = 5;
            string desc = "Your hero is now using the Axe!";
            return desc;
        }

        public string fists()
        {
            damageMax = 7;
            damageMin = 3;
            string desc = "Your hero is now using their fists!";
            return desc;
        }
    }
}

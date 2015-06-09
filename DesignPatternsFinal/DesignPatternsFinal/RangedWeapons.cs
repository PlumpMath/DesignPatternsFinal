using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class RangedWeapons : IWeaponBehavior
    {
        private int damageMax;
        private int damageMin;
        public RangedWeapons()
        { }

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
            Console.WriteLine("Choose a ranged weapon: ");
            Console.WriteLine("1) Bow and Arrow");
            Console.WriteLine("2) Staff");
            Console.WriteLine("3) Javelin");
            Console.WriteLine("4) Throwing Knife");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: desc = BowNArrow();
                        return desc;
                    case 2: desc = staff();
                        return desc;
                    case 3: desc = javelin();
                        return desc;
                    case 4: desc = throwingKnife();
                        return desc;
                    default: desc = fists();
                        return desc;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a number corresponding to the weapon of choice.");
                weapon();
            }
            return desc;

        }

        public string BowNArrow()
        {
            damageMax = 25;
            damageMin = 10;
            string desc = "";
            desc = "Your hero is now using a Bow and Arrow!";
            return desc;
        }

        public string staff()
        {
            damageMax = 20;
            damageMin = 5;
            string desc = "";
            desc = "Your hero is now using a staff!";
            return desc;
        }

        public string javelin()
        {
            damageMax = 30;
            damageMin = 1;
            string desc = "";
            desc = "Your hero is now using a Javelin!";
            return desc;
        }

        public string throwingKnife()
        {
            damageMax = 10;
            damageMin = 6;
            string desc = "";
            desc = "Your hero is now using a Throwing Knife!";
            return desc;
        }

        public string fists()
        {
            
            damageMax = 7;
            damageMin = 3;
            string desc = "";
            desc = "Your hero is now using their fists!";
            return desc;

        }
    }
}

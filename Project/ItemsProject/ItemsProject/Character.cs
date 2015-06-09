using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemsProject
{
    class Character
    {
        private IWeaponBehavior wepBehav;
        public Character()
        {
        }

        public void printWeapon()
        {
            wepBehav.weapon();
            Console.WriteLine(wepBehav.getDamageMax() + ", " + wepBehav.getDamageMin());
        }

        public void setWeapon(IWeaponBehavior weapon)
        {
            this.wepBehav = weapon;
        }
    }
}

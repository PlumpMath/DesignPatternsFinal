using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItemsProject
{
    interface IWeaponBehavior
    {
        void weapon();
        int getDamageMin();
        int getDamageMax();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Medusa : Beast
    {
		private static boolean defeated;
		private static Medusa it;

        public Medusa()
        {
            Name = "Medusa";
            HP = 1000;
            maxHP = 1000;
            Str = 14;
            Dex = 16;
            Mag = 22;
            Con = 18;
            Wis = 17;
            Cha = 15;
            Stance = 1.0;
			defeated = false;
        }

		public static Medusa getMedusa()
		{
			if( it == null )
				it = new Medusa();
			return it;
		}

		public Boolean isDefeated()
		{
			return defeated;
		}

		override
		public Item defeat()
		{	
			defeated = true;
			return null;
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    class Cerberus : Beast
    {
		private static bool defeated;
		private static Cerberus it;

        private Cerberus() : base() 
        {
            Name = "Cerberus";
            HP = 1000;
            maxHP = 1000;
            Str = 20;
            Dex = 20;
            Mag = 12;
            Con = 18;
            Wis = 13;
            Cha = 10;
            Stance = 1.0;
			defeated = false;
        }

		public static Cerberus getCerberus()
		{
			if( it == null )
				it = new Cerberus();
			return it;
		}

		public static Boolean isDefeated()
		{
			return defeated;
		}

		override
		public Item defeat()
		{	
			defeated = true;
            return new Helmet();
		}
    }
}


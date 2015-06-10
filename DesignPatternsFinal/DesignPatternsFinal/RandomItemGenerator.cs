using System;
using System.Collections.Generic;

namespace DesignPatternsFinal
{
	class RandomItemGenerator
	{
		public static Item getItem( int roomNum )
		{
			Random rand = new Random();
			double choice = rand.NextDouble ();
			Item it;

			if (roomNum != 1 && roomNum != 31 && roomNum != 54) 
			{
				if( choice > .90)
				{
					return new BowNArrow ();
				}
				else if( choice > .80)
				{
					return new poisonHP();
				}
				else if( choice > .65)
				{
					return new Javelin();
				}
				else if( choice > .40)
				{
					return new Bracers();
				}
				else if( choice > .25)
				{
					return new LongSword();
				}
				else
				{
					return new healHP();
				}
			} 
			else
			{
				if (roomNum == 31) 
				{
					return new Helmet();
				} 
				else 
				{
					return new Mace()
				}
			}
		}
	}
}

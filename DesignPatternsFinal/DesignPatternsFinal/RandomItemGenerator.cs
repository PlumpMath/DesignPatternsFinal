using System;
using System.Collections.Generic;

namespace DesignPatternsFinal
{
	class RandomItemGenerator
	{
		public static Item getItem()
		{
			Random rand = new Random();
			double choice = rand.NextDouble ();
			Item it;

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
	}
}

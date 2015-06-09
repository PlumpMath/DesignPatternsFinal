using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
	class RandomEnemyGenerator
	{
		public static Party getEnemies( Room room )
		{
			Random rand = new Random();
			double choice = rand.NextDouble ();
			Party party = new Party ();
            int roomNum = room.getRoomNum();

			if (roomNum > 31) 
			{
				if (choice < .33) 
				{
					party.addCharacter (new Minotaur ());
				} 
				else if (choice < .66) 
				{
					party.addCharacter (new Hydra ());
					party.addCharacter (new Hydra ());
				} 
				else 
				{
					party.addCharacter (new Siren ());
					party.addCharacter (new Siren ());
					party.addCharacter (new Siren ());
				}
			} 
			else 
			{
				if (choice < .33) 
				{
                    party.addCharacter(new Gorgon());
                    party.addCharacter(new Gorgon());
                    party.addCharacter(new Gorgon());
				} 
				else if (choice < .66) 
				{
					party.addCharacter (new Griffin ());
					party.addCharacter (new Griffin ());
				} 
				else 
				{
					party.addCharacter (new Chimera ());
					party.addCharacter (new Chimera ());
					party.addCharacter (new Chimera ());
				}
			}

			return party;
		}
	}
}

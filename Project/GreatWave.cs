using System;

namespace DesignPatternsProject
{
	public class GreatWave : IAbility
	{	

		public void ability( Party party )
		{
			Console.WriteLine ("Poseidon sends out a great wave!");

			foreach (Character enemy in party) 
			{
				int oldHP = enemy.getHp();
				double damage = (50 - enemy.getConstitution()) * enemy.getStanceMultiplier();
				double newHP = oldHP - damage;
				enemy.setHp((int)newHP);

				Console.WriteLine(enemy.getName() + " was hit by the great wave.");
				Console.WriteLine(enemy.getName() + " lost " + enemy.getStength() + " HP and now has "
				                  + enemy.getHp() + " left.");
			}
		}
	}
}


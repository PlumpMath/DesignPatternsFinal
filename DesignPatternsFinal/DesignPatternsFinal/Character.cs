using System;
using System.Collections.Generic;

namespace DesignPatternsFinal
{
    public abstract class Character : ICloneable
    {
        private string name;
        public String Name { get { return name; } set { name = value; } }
        private int hp;
        public int HP { get { return hp; } set { hp = value; } }
        private int maxHp;
        public int maxHP { get { return maxHp; } set { maxHp = value; } }
		private int level;
		public int Level { get { return level; } set { hp = level; } }
		private int xp;
		public int XP { get { return xp; } set { xp = value; } }
        private int strength;
        public int Str { get { return strength; } set { strength = value; } }
        private int dexterity;
        public int Dex { get { return dexterity; } set { dexterity = value; } }
        private int magic;
        public int Mag { get { return magic; } set { magic = value; } }
        private int constitution;
        public int Con { get { return constitution; } set { constitution = value; } }
        private int wisdom;
        public int Wis { get { return wisdom; } set { wisdom = value; } }
        private int charisma;
        public int Cha { get { return charisma; } set { charisma = value; } }
        private double stanceMultiplier;
        public double Stance { get { return stanceMultiplier; } set { stanceMultiplier = value; } }

        public System.Collections.Generic.List<IAbility> moves;
        //private Armor armor;
        //private Weapon weapon;
    
        public Character(){
            moves = new List<IAbility>();
            moves.Add(new Attack(this));
            moves.Add(new Defend(this));
			Level = 1;
			XP = 0;
            //moves.Add(new Item(this));
        }
        public enum MOVES
        {
            ATTACK = 0,
            DEFEND = 1,
            SPECIAL = 2,
            ITEM = 3
        }

        public abstract IAbility turn(Party team, Party enemies );
        public abstract Character aim(Party enemy);

		public void levelUp()
		{
			if (XP > Level * 500) ;
			{
				HP += 50;
				maxHP += 50;
				Level++;
				XP = 0;
				Str++;
				Dex++;
				Mag++;
				Con++;
				Wis++;
				Cha++;
			}
		}

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
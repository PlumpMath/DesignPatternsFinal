using System;

namespace DesignPatternsFinal
{
    public abstract class Character : ICloneable
    {
        private string name;
        public String Name { get {return name; } set {name=value; } }
        private int hp;
        public int HP { get {return hp; } set {hp=value; } }
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
    
        public Character(){}

        public abstract String turn( ref Party team, ref Party enemies );
        public abstract Character aim(ref Party enemy);

        public string attack(Party enemy)
        {
            string response = "";
            //this.setStanceMultiplier(1.0);
            Stance = 1.0;
            Character target = aim(ref enemy);

            //int oldHP = target.getHp();
            int oldHP = target.HP;
            //double newHP = oldHP - this.getStength() * target.getStanceMultiplier();
            double newHP = oldHP - this.Str * target.Stance;
            //target.setHp((int)newHP);
            target.HP=((int)newHP);

            //Console.WriteLine(this.getName() + " attacked " + target.getName() + ".");
            //response += this.getName() + " attacked " + target.getName() + ".\n";
            response += this.Name + " attacked " + target.Name + ".\n";
            //response += target.getName() + " lost " + this.getStength() + " HP and now has " + target.getHp() + " left.";
            response += target.Name + " lost " + this.Str + " HP and now has " + target.HP + " left.";
            /*Console.WriteLine(target.getName() + " lost " + this.getStength() + " HP and now has "
                + target.getHp() + " left.");*/
            return response;
        }


        public string defend()
        {
            //setStanceMultiplier(.25); 
            Stance = .25;
            //return (this.getName() + " is now defending.");
            return(this.Name + " is now defending.");
            //Console.WriteLine(this.getName() + " is now defending.");
            
        }
        /*
        public int getSpeed()
        {
            return 50 - this.dexterity;
        }

        public string getName()
        {
            return this.name;
        }

        public int getHp()
        {
            return this.hp;
        }

        public int getStength()
        {
            return this.strength;
        }

        public int getDexterity()
        {
            return this.dexterity;
        }

        public int getMagic()
        {
            return this.magic;
        }
        public int getConstitution()
        {
            return this.constitution;
        }

        public int getWisdom()
        {
            return this.wisdom;
        }

        public int getCharisma()
        {
            return this.charisma;
        }

        public double getStanceMultiplier()
        {
            return this.stanceMultiplier;
        }

        public void setName( string name )
        {
            this.name = name;
        }

        public void setHp( int hp )
        {
            this.hp = hp;
        }

        public void setStrength(int str)
        {
            this.strength = str;
        }

        public void setDexterity(int dex)
        {
            this.dexterity = dex;
        }

        public void setMagic(int mag)
        {
            this.magic = mag;
        }

        public void setConstitution(int con)
        {
            this.constitution = con;
        }

        public void setWisdom(int wis)
        {
            this.wisdom = wis;
        }

        public void setCharisma(int cha)
        {
            this.charisma = cha;
        }

        public void setStanceMultiplier( double stance )
        {
            this.stanceMultiplier = stance;
        }*/

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
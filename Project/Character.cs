using System;

namespace DesignPatternsFinal
{
    public abstract class Character
    {
        private string name;
        private int hp;
        private int strength;
        private int dexterity;
        private int magic;
        private int constitution;
        private int wisdom;
        private int charisma;

        private double stanceMultiplier;
        //private Armor armor;
        //private Weapon weapon;
    
        public Character(){}

        public abstract void turn( Party team, Party enemies );
        public abstract Character aim(Party enemy);

        public string attack(Party enemy)
        {
            string response = "";
            this.setStanceMultiplier(1.0);
            Character target = aim(enemy);

            int oldHP = target.getHp();
            double newHP = oldHP - this.getStength() * target.getStanceMultiplier();
            target.setHp((int)newHP);

            //Console.WriteLine(this.getName() + " attacked " + target.getName() + ".");
            response += this.getName() + " attacked " + target.getName() + ".\n";
            response += target.getName() + " lost " + this.getStength() + " HP and now has " + target.getHp() + " left.";
            /*Console.WriteLine(target.getName() + " lost " + this.getStength() + " HP and now has "
                + target.getHp() + " left.");*/
            return response;
        }


        public string defend()
        {
            setStanceMultiplier(.25);
            return(this.getName() + " is now defending.");
            //Console.WriteLine(this.getName() + " is now defending.");
            
        }

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
        }
    }
}
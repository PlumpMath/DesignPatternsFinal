using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class Inventory : IAbility
    {
        private Character owner;
        private System.Collections.Generic.List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }
        public List<Item> getList()
        {
            return items;
        }

        public void add(Item item)
        {
            items.Add(item);
        }
        public string getName()
        {
            return "Inventory";
        }
        public Inventory(Character own)
        {
            owner = own;
        }

        public string ability(Party party)
        {
            string response = "";
            Inventory inv;
            inv = party.getInventory();
            Item item = owner.inventoryShow(party, inv);

            response += owner.Name + " has equipped a " + item.getname() + ". ";
            if(item.getname().Contains("Heal"))
            {
                Random number = new Random();
                int max = item.getHealMax();
                int min = item.getHealMin();
                int heal = number.Next(min, max + 1);
                if(item.getname().Contains("Wisdom"))
                {
                    owner.Wis += heal; 
                }
                else if(item.getname().Contains("Strength"))
                {
                    owner.Str += heal;
                }
                else if(item.getname().Contains("Magic"))
                {
                    owner.Mag += heal;
                }
                else if(item.getname().Contains("Health"))
                {
                    owner.HP += heal;
                }
                else if(item.getname().Contains("Dexterity"))
                {
                    owner.Dex += heal;
                }
                else if(item.getname().Contains("Constituition"))
                {
                    owner.Con += heal;
                }
                else if(item.getname().Contains("Charisma"))
                {
                    owner.Cha += heal;
                }
            }
            else if (item.getname().Contains("Poison"))
            {
                Random number = new Random();
                int max = item.getPoisonMax();
                int min = item.getPoisonMin();
                int poison = number.Next(min, max + 1);
                if (item.getname().Contains("Wisdom"))
                {
                    owner.Wis -= poison;
                }
                else if (item.getname().Contains("Strength"))
                {
                    owner.Str -= poison;
                }
                else if (item.getname().Contains("Magic"))
                {
                    owner.Mag -= poison;
                }
                else if (item.getname().Contains("Health"))
                {
                    owner.HP -= poison;
                }
                else if (item.getname().Contains("Dexterity"))
                {
                    owner.Dex -= poison;
                }
                else if (item.getname().Contains("Constituition"))
                {
                    owner.Con -= poison;
                }
                else if (item.getname().Contains("Charisma"))
                {
                    owner.Cha -= poison;
                }
            }
            else if(item.getBlockMax() > 0)
            {
                Random number = new Random();
                int max = item.getBlockMax();
                int min = item.getBlockMin();
                int blk = number.Next(min, max + 1);
                owner.Dex += blk;
            }
            else if(item.getDamageMax() > 0)
            {
                Random number = new Random();
                int max = item.getDamageMax();
                int min = item.getDamageMin();
                int dmg = number.Next(min, max + 1);
                owner.Str += dmg;
            }
            return response;
        }
    }
}

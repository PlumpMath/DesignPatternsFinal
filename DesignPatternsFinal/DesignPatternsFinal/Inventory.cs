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
                
            }
            else if (item.getname().Contains("Poison"))
            {

            }
            else if(item.getBlockMax() > 0)
            {

            }
            else if(item.getDamageMax() > 0)
            {

            }
            return response;
        }
    }
}

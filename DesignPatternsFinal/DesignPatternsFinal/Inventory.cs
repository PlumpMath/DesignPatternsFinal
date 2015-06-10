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
            return response;
        }
    }
}

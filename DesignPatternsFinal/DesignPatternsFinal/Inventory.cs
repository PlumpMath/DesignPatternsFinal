using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public abstract class Inventory : IAbility
    {
        private Character owner;
        private System.Collections.Generic.List<Item> items;

        public Inventory()
        {
            Item a;
            items = new List<Item>();
            items.Add(a = new LongSword());
            items.Add(a = new BowNArrow());
            items.Add(a = new Dagger());
            items.Add(a = new Helmet());
            items.Add(a = new Curiass());
        }

        public abstract List<Item> getList();

        public string getName()
        {
            return "Inventory";
        }
        public Inventory(Character own)
        {
            owner = own;
        }

        public void add(Item item)
        {
            items.Add(item);
        }

        public string ability(Party party)
        {
            string response = "";
            InventoryViewForm form = new InventoryViewForm(items);
            form.Show();
            return response;
        }
    }
}

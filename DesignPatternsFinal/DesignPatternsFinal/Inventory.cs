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
            items.Add(new LongSword());
            items.Add(new BowNArrow());
            items.Add(new Dagger());
            items.Add(new Helmet());
            items.Add(new Curiass());
        }

        public List<Item> getList()
        {
            return items;
        }

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

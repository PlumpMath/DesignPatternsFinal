using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public abstract class InventoryDecorator : Inventory
    {
        protected Inventory inventoryList;

        public InventoryDecorator(Inventory inventoryList)
        {
            this.inventoryList = inventoryList;
        }
        override
        public List<Item> getList(List<Item> items)
        {
            return inventoryList.getList(items);
        }
    }
}

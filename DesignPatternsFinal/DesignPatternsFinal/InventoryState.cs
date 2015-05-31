using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsFinal
{
    public class InventoryState : State
    {
        private static InventoryState _inventoryState;
        private System.Windows.Forms.Form InventoryForm;

        private InventoryState()
        {
            InventoryForm = new InventoryViewForm();
            base.inventoryState = _inventoryState;
        }
        override protected void toInventory()
        {
            
        }
        override public System.Windows.Forms.Form StateView()
        {
            return InventoryForm;
        }

        internal static State initInventoryState()
        {
            if (_inventoryState == null)
                _inventoryState = new InventoryState();
            return _inventoryState;
        }
    }
}

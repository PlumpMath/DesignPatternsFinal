using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsFinal
{
    public partial class InventoryViewForm : Form
    {
        private List<Item> items;
        private Inventory inventory;
        private Character current;
        private string response;
        private Item item;
        public InventoryViewForm(Inventory obj, Character owner)
        {
            inventory = obj;
            current = owner;
            InitializeComponent();
        }
        public string getResponse()
        {
            return response;
        }

        private void InventoryViewForm_Load(object sender, EventArgs e)
        {
            items = inventory.getList();
            int x = 0;
            foreach (Item p in items)
            {
                CheckBox check = new CheckBox();
                check.Text = p.getname();
                check.Location = new System.Drawing.Point(0, 22 * x);
                this.InventoryCheckBox.Controls.Add(check);
                x++;
            }
            this.Update();
            this.Show();
            InventoryLabel.Text = "Choose an item to equip to " + current.Name;
        }

        public Item getDecision()
        {
            response = item.getname();
            Close();
            return item;
        }

        private void equipButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            int i = 0;
            foreach (CheckBox c in this.InventoryCheckBox.Controls)
            {
                if(c.Checked)
                {
                    for (i = 0; i < items.Count && !items[i].getname().Equals(c.Text); i++) ;
                    if (i != items.Count)
                        item = items[i];
                    count ++;
                }
            }
            if(count > 1 || count <= 0)
            {
                MessageBox.Show("Please check only one item, or click the close button.");
                foreach(CheckBox c in this.InventoryCheckBox.Controls)
                {
                    c.Checked = false;
                }
            }
            else
            {
                getDecision();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

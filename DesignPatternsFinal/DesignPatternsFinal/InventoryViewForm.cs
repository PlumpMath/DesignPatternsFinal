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
        private Character owner;
        public InventoryViewForm(List<Item> obj)
        {
            InitializeComponent();
            int x = 0;
            foreach (List<Item> p in obj)
            {
                CheckBox check = new CheckBox();
                //check.Text = p.Name;
                check.Location = new System.Drawing.Point(0, 22 * x);
                this.InventoryCheckBox.Controls.Add(check);
                x++;
            }
            this.Update();
            this.Show();
        }

        private void EquipInventoryButton_Click(object sender, EventArgs e)
        {

        }

        private void closeInventoryButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

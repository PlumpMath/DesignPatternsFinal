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
    public partial class PrimaryViewForm : Form
    {
        private static World theWorld;
        private static PrimaryViewForm thisPtr;

        public PrimaryViewForm(World world)
        {
            theWorld = world;
            InitializeComponent();
            int i=0;
            foreach(Character c in theWorld.heroParty)
            {
                Label cname = new Label();
                cname.Text = c.Name + "\t HP: " + c.HP;
                cname.Location = new System.Drawing.Point(0, 22 * i);
                this.partyBox.Controls.Add(cname);
                i++;
            }
            this.Update();
            this.Show();
            thisPtr = this;
        }
        public static void onUpdate()
        {
            int i=0;
            thisPtr.partyBox.Controls.Clear();

            foreach(Character c in theWorld.heroParty)
            {
                Label cname = new Label();
                cname.Text = c.Name + "\t HP: " + c.HP + "/" + c.maxHP;
                cname.Location = new System.Drawing.Point(0, 22 * i);
                thisPtr.partyBox.Controls.Add(cname);
                i++;
            }
            thisPtr.Update();
        }
    }
}

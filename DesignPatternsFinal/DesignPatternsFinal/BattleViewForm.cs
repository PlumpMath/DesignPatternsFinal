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
    public partial class BattleViewForm : Form
    {
        private Party enemies;
        public BattleViewForm()
        {
            InitializeComponent();
        }
        public void newBattle(BattleEvent theEvent)
        { 
            enemies = theEvent.getFoes();
            int i = 0;

            foreach (Character c in enemies)
            {
                Label cname = new Label();
                cname.Text = c.Name + "\t HP: " + c.HP;
                cname.Location = new System.Drawing.Point(0, 22 * i);
                this.badguyBox.Controls.Add(cname);
                i++;
            }
            battleOutput.Text = theEvent.startFight().battle();
            this.Update();
            this.Show();
        }

    }
}

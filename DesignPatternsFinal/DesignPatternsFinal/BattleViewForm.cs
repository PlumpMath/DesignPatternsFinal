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
            Return.Visible = false;
        }
        public void refreshEnemies()
        {
            int i = 0;
            this.badguyBox.Controls.Clear();
            foreach (Character c in enemies)
            {
                Label cname = new Label();
                cname.Text = c.Name + "\t HP: " + c.HP + "/" + c.maxHP;
                cname.Location = new System.Drawing.Point(0, 22 * i);
                this.badguyBox.Controls.Add(cname);
                i++;
            }
            this.Update();
        }
        public void newBattle(BattleEvent theEvent)
        { 
            enemies = theEvent.getFoes();
           
            while(theEvent.theFight().stillFighting())
            {
                refreshEnemies();
                battleOutput.Text = theEvent.theFight().turn() + "\n";
                this.Update();
                PrimaryViewForm.onUpdate();
            }
            Return.Visible = true;
            this.Update();
            this.Show();
        }
        public void refreshView()
        {
            int i = 0;
            foreach (Character c in enemies)
            {
                Label cname = new Label();
                cname.Text = c.Name + "\t HP: " + c.HP + "/" + c.maxHP;
                cname.Location = new System.Drawing.Point(0, 22 * i);
                this.badguyBox.Controls.Add(cname);
                i++;
            }
            this.Update();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            State.toNavigate();
        }
    }
}

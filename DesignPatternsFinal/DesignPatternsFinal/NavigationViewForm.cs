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
    public partial class NavigationViewForm : Form
    {
        private World theWorld;
        private Dungeon _dungeon;

        public NavigationViewForm(ref World world)
        {
            theWorld = world;
            _dungeon = world.theDungeon;
            
            InitializeComponent();
            
            int x = 0;
            foreach (Room r in theWorld.theDungeon.adjacent())
            {
                Button theButton = new Button();
                theButton.Text = r.getDes();
                theButton.Location = new System.Drawing.Point(0, 22 * x);
                theButton.Click += delegate
                {
                    _dungeon.moveTo(r);
                    this.repopulate();
                    this.Update();
                };
                this.navigationControl.Controls.Add(theButton);
                x++;
            }
            RoomPanel.Text = _dungeon.getCurrent().getDes();
        }

        private void repopulate()
        {
            navigationControl.Controls.Clear();
            int x = 0;
            foreach (Room r in _dungeon.adjacent())
            {
                Button theButton = new Button();
                theButton.Text = r.getDes();
                theButton.Location = new System.Drawing.Point(0, 22 * x);
                theButton.Width = 150;
                theButton.Click += delegate
                {
                    _dungeon.moveTo(r);
                    //this.
                    this.repopulate();
                    this.Update();
                };
                this.navigationControl.Controls.Add(theButton);
                x++;
            }
            RoomPanel.Text = _dungeon.getCurrent().getDes();
        }

        private void NavigationViewForm_Load(object sender, EventArgs e)
        {
            
        }

        private void NavigationViewForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

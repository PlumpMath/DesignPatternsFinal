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
    public partial class NewGameForm : Form
    {
        private Party heroTemp;
        private CheckedListBox checkedListBox1;
        private Button button1;
        private Dictionary<String, God> poolTemp;
        public NewGameForm(Party heros, Dictionary<String,God> pool)
        {
            heroTemp = heros;
            poolTemp = pool;
            InitializeComponent();
            int x = 0;
            foreach (KeyValuePair<String, God> p in pool)
            {
                CheckBox check = new CheckBox();
                check.Text = p.Value.getName();
                check.Location = new System.Drawing.Point(0, 22*x);
                this.checkedListBox1.Controls.Add(check);
                x++;
            }
            this.Update();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(CheckBox c in checkedListBox1.Controls)
            {
                heroTemp.addCharacter(poolTemp[c.Text]);
            }
            World theWorld = World.init(heroTemp);
            theWorld.init();
            this.Hide();
        }

        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(260, 169);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Begin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewGameForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "NewGameForm";
            this.ResumeLayout(false);

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox items = (CheckedListBox)sender;
            if (items.CheckedItems.Count > 2)
            {
                e.NewValue = CheckState.Unchecked;
                this.Update();
            }
            items.Update();
        }
    }
}
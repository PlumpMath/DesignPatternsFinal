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
    public partial class CharacterSelectForm : Form
    {
        private Character decision;
        private Party target;

        public CharacterSelectForm(Party there)
        {
            InitializeComponent();

            Party target;
            target = there;
        }
        public Character getDecision()
        {
            this.Close();
            return decision;
        }
        private void DecisionSelectForm_Load(object sender, EventArgs e)
        {
            int x = 0;
            foreach (Character c in target)
            {
                Button theButton = new Button();
                theButton.Text = c.Name;
                theButton.Location = new System.Drawing.Point(0, 22 * x);
                theButton.Click += delegate
                {
                    decision = c;
                    this.getDecision();
                    this.Update();
                };
                this.selectionBox.Controls.Add(theButton);
                x++;
            }
        }
    }
}

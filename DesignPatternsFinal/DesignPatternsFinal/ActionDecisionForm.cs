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
    public partial class ActionDecisionForm : Form
    {
        private God current;
        private IAbility decision;
        public ActionDecisionForm(God player)
        {
            current = player;

            InitializeComponent();
        }
        public IAbility getDecision()
        {
            this.Close();
            return decision;
        }
        private void ActionDecisionForm_Load(object sender, EventArgs e)
        {
            int x = 0;
            foreach (IAbility c in current.moves)
            {
                Button theButton = new Button();
                theButton.Text = c.getName();
                theButton.Location = new System.Drawing.Point(0, 22 * x);
                theButton.Click += delegate
                {
                    decision = c;
                    this.getDecision();
                    this.Update();
                };
                this.actionBox.Controls.Add(theButton);
                x++;
            }
        }
    }
}

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
        public NavigationViewForm()
        {
            InitializeComponent();
        }

        private void NavigationViewForm_Load(object sender, EventArgs e)
        {

        }

        private void NavigationViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

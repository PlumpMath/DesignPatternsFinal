using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsProject
{
    public partial class Form1 : Form
    {
        private Poseidon bob;
        private Beast joe;
        private Party hero_party;
        private Party enemy_party;
        private Battle battle_event;
        ConsoleToTextbox_Adaptor _writer = null;

        public Form1()
        {
            /*List<Character> h = new List<Character>();
            for (int i = 0; i < 3; i++)
                h.Add(new Poseidon());
            List<Character> a = new List<Character>();
            for (int i = 0; i < 2; i++)
                a.Add(new Beast());

            Party home = new Party(h);
            Party away = new Party(a);

            Battle battlefield = new Battle(home, away);
            battlefield.battle();*/


            bob = new Poseidon();
            joe = new Beast();
            enemy_party = new Party();
            hero_party = new Party();
            hero_party.addCharacter(bob);
            enemy_party.addCharacter(joe);
            battle_event = new Battle(hero_party, enemy_party);
            
            InitializeComponent();
            
            this.label1.Text = bob.getName();
            this.label2.Text = "HP: " + bob.getHp().ToString();
            this.label3.Text = "SP: " + bob.getSpeed().ToString();
            this.label4.Text = "MP: " + bob.getMagic().ToString();

            this.label5.Text = joe.getName();
            this.label6.Text = "HP: " + joe.getHp().ToString();
            this.label7.Text = "SP: " + joe.getSpeed().ToString();
            this.label8.Text = "MP: " + joe.getMagic().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            battle_event.battle();
            bob.attack(enemy_party);
            joe.attack(hero_party);
            bob.defend();
            this.Update();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Instantiate the writer
            _writer = new ConsoleToTextbox_Adaptor(txtConsole);
            // Redirect the out Console stream
            Console.SetOut(_writer);

            Console.WriteLine("Now redirecting output to the text box");
        }
    }
}

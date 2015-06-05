﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsFinal
{
    public partial class MainForm : Form
    {
        //private World gameWorld;
        private ConsoleToTextbox_Adaptor _writer;

        public MainForm()
        {
            InitializeComponent();
            //SplashForm Splash = new SplashForm();
            //Splash.Show();

            this.Show();
            //Splash.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            God hero1 = new Poseidon();
            God hero2 = new Zeus();
            God hero3 = new Ares();
            God hero4 = new Hades();
            God hero5 = new Nike();

            Party heroParty = new Party();
            Dictionary<String, God> hero_list = new Dictionary<String, God>();
            hero_list.Add(hero1.Name, hero1);
            hero_list.Add(hero2.Name, hero2);
            hero_list.Add(hero3.Name, hero3);
            hero_list.Add(hero4.Name, hero4);
            hero_list.Add(hero5.Name, hero5);
            NewGameForm newGame = new NewGameForm(ref heroParty, ref hero_list);
            this.Hide();
            //gameWorld = new World();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                World gameWorld;
                Stream TestFileStream = File.OpenRead("SerialSave");
                BinaryFormatter deserializer = new BinaryFormatter();
                gameWorld = (World)deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();
                gameWorld.init();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void stub_saveWorld()
        {
            Stream TestFileStream = File.Create("SerialSave");
            BinaryFormatter serializer = new BinaryFormatter();
            //serializer.Serialize(TestFileStream, gameWorld);
            TestFileStream.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _writer = new ConsoleToTextbox_Adaptor(textConsole);
            Console.SetOut(_writer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
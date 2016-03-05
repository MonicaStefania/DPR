using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyFactory
{
    public partial class Form1 : Form
    {
        string FILE_PATH = "";
        IToys factory;
        GenericToyFactory game = new GenericToyFactory();
        Form2 dollForm = new Form2();
        Form3 petForm = new Form3();

        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Image = Properties.Resources.eatingdog;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/furby_talk.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }

        private void dollsbutton_Click(object sender, EventArgs e)
        {
            dollForm.Show();
        }

        private void petsbutton_Click(object sender, EventArgs e)
        {
            petForm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void jumpButton_Click(object sender, EventArgs e)
        {
            game.performAction("jump");
            this.pictureBox1.Image = game.avatar();

        }

        private void btnaddBarbie_Click(object sender, EventArgs e)
        {
            factory = new KidsToys();
            game.run(factory, "Monica", "girl");
            this.pictureBox1.Image = game.avatar();
        }

        private void cryButton_Click(object sender, EventArgs e)
        {
            game.performAction("cry");
            this.pictureBox1.Image = game.avatar();
        }

        private void talkButton_Click(object sender, EventArgs e)
        {
            game.performAction("talk");
            this.pictureBox1.Image = game.avatar();
        }

        private void eatButton_Click(object sender, EventArgs e)
        {
            game.performAction("eat");
            this.pictureBox1.Image = game.avatar();
        }

        private void sleepButton_Click(object sender, EventArgs e)
        {
            game.performAction("sleep");
            this.pictureBox1.Image = game.avatar();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            game.performAction("play");
            this.pictureBox1.Image = game.avatar();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           
                SaveFileDialog myDialog = new SaveFileDialog();
                myDialog.Title = "Save toy";
                myDialog.DefaultExt = ".XML";
                if (myDialog.ShowDialog() == DialogResult.OK & myDialog.FileName != null)
                {
                    GenericToyFactory.SaveToFile(game, myDialog.FileName);
                    FILE_PATH = myDialog.FileName;
                }
          
            
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to save your changes?", "Save?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                saveBtn.PerformClick();
                OpenFileDialog load = new OpenFileDialog();
                if (load.ShowDialog() == DialogResult.OK)
                {
                    load.Title = "Load from file";
                    FILE_PATH = load.FileName;
                    game = GenericToyFactory.LoadFromFile(load.FileName);
                    this.pictureBox1.Invalidate();
                    this.Invalidate();
                }
            }
            else if (dialog == DialogResult.No)
            {
                OpenFileDialog load = new OpenFileDialog();
                if (load.ShowDialog() == DialogResult.OK)
                {
                    FILE_PATH = load.FileName;
                    load.Title = "Load from file";
                    game = GenericToyFactory.LoadFromFile(load.FileName);
                    this.pictureBox1.Invalidate();

                    this.Invalidate();
                }
            }
        }
    }
}

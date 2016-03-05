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

        }
    }
}

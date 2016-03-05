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
    public partial class ToyFactory : Form
    {
        string FILE_PATH = "";
        IToys factory;
        GenericToyFactory game = new GenericToyFactory();

        public ToyFactory()
        {
            InitializeComponent();
            invalidateButtons();

        }


        private void btnJump_Click(object sender, EventArgs e)
        {
            game.performAction("jump");
            this.pictureBox1.Image = game.getAvatar();

        }

        private void btnAddToy_Click(object sender, EventArgs e)
        {

            if (rbBarbie.Checked)
            {
                factory = new KidsToys();
                game.run(factory, textBox1.Text, "girl");
                this.pictureBox1.Image = game.getAvatar();
                toyNameLabel.Text = textBox1.Text;
            
            }
            if (rbBaby.Checked)
            {
                factory = new InfantToys();
                game.run(factory, textBox1.Text, "girl");
                this.pictureBox1.Image = game.getAvatar();
                toyNameLabel.Text = textBox1.Text;
            }
            if (rbFurby.Checked)
            {
                factory = new KidsToys();
                game.run(factory, textBox1.Text, "boy");
                this.pictureBox1.Image = game.getAvatar();
                toyNameLabel.Text = textBox1.Text;

            }
            else if (rbSparky.Checked)
            {
                factory = new InfantToys();
                game.run(factory, textBox1.Text, "boy");
                this.pictureBox1.Image = game.getAvatar();
                toyNameLabel.Text = textBox1.Text;
            }

            this.rbBaby.Enabled = false;
            this.rbBarbie.Enabled = false;
            this.rbFurby.Enabled = false;
            this.rbSparky.Enabled= false;
            this.textBox1.Enabled = false;
            this.btnAddToy.Enabled = false;
            enableButtons();
        }

        private void btnCry_Click(object sender, EventArgs e)
        {

            game.performAction("cry");
            this.pictureBox1.Image = game.getAvatar();
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {

            game.performAction("talk");
            this.pictureBox1.Image = game.getAvatar();
        }

    

    private void btnEat_Click(object sender, EventArgs e)
    {

        game.performAction("eat");
        this.pictureBox1.Image = game.getAvatar();
    }


        private void btnSleep_Click(object sender, EventArgs e)
        {
            
                game.performAction("sleep");
                this.pictureBox1.Image = game.getAvatar();
         
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
                game.performAction("play");
                this.pictureBox1.Image = game.getAvatar();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to save your changes?", "Save?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                btnSave.PerformClick();
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
                    this.pictureBox1.Image = game.getAvatar();
                    this.toyNameLabel.Text = game.getName();


                 
                }
            }
            this.rbBaby.Enabled = false;
            this.rbBarbie.Enabled = false;
            this.rbFurby.Enabled = false;
            this.rbSparky.Enabled = false;
            this.textBox1.Enabled = false;
            this.btnAddToy.Enabled = false;
            enableButtons();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            toyNameLabel.Text = "";
            pictureBox1.Invalidate();
            invalidateButtons();
            this.rbBaby.Enabled = true;
            this.rbBarbie.Enabled = true;
            this.rbFurby.Enabled = true;
            this.rbSparky.Enabled = true;
            this.textBox1.Enabled = true;
            this.btnAddToy.Enabled = true;

        }
        private void invalidateButtons()
        {
            this.btnRemove.Enabled = false; 
            this.btnCry.Enabled = false;
            this.btnEat.Enabled = false;
            this.btnJump.Enabled = false;
            this.btnPlay.Enabled = false;
            this.btnSleep.Enabled = false;
            this.btnTalk.Enabled = false;
        }
        private void enableButtons()
        {
            this.btnRemove.Enabled = true;
            this.btnCry.Enabled = true;
            this.btnEat.Enabled = true;
            this.btnJump.Enabled = true;
            this.btnPlay.Enabled = true;
            this.btnSleep.Enabled = true;
            this.btnTalk.Enabled = true;
        }
    }
}

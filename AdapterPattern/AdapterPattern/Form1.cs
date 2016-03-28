using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPattern
{
    public partial class Form1 : Form
    {
        IIos ioS;
        IAndroid android;
        GameAdapter adapter;
            public Form1()
        {
            InitializeComponent();
            
           
           
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void btniOs_Click(object sender, EventArgs e)
        {
            ioS = new Iphone();
            //label1.Text = adapter.TransmitGame(txtboxInfo.Text);
            label1.Text =  ioS.RunIosGame(txtboxInfo.Text);
            pictureBox1.Visible = true;
        }

        private void btnAndroid_Click(object sender, EventArgs e)
        {
            android = new Samsung();
            label2.Text = android.RunAndroidGame(txtboxInfo.Text);
            pictureBox2.Visible = true;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new GameAdapter( new Iphone());
            lbInfo.Text = adapter.TransformGame(txtboxInfo.Text);
            
        }
    }
}

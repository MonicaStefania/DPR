using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiskScheduling
{
    public partial class Form1 : Form
    {

        OperatinSystem OS;
        DiskSchedule d;

        //int[] num = new int[100];
        public Form1()
        {
            InitializeComponent();
            OS = new OperatinSystem(d);
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                //d = new FIFO();
                d = new SCAN();
                timer1.Start();
            }
        
                  }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int i in d.)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}

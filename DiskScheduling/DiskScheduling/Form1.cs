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
        DiskSchedule d = new FIFO();
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
           //num= OS.performDiskSchedule();
           // foreach (int i in num)
           // {
           //     this.listBox1.Items.Add(num[i]);
           // }
        }
    }
}

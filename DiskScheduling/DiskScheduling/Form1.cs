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

        int[] num = new int[100];
        public Form1()
        {
            InitializeComponent();
            
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
                d = new FIFO();
                OS = new OperatinSystem(d);
                timer1.Start();
            }
            else { if (radioButton2.Checked)
                {
                    d = new ShortestSeekTime();
                    OS = new OperatinSystem(d);
                    timer1.Start();
                }
                else {  if (radioButton3.Checked)
                    {
                        d = new SCAN();
                        OS = new OperatinSystem(d);
                        timer1.Start();
                    }
                }
            }

            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            num = OS.performDiskSchedule();
            foreach (int i in num)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}

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

        OperatingSystem OS;
        bool doneSignal = false;
        int currentValue;
        List<int> myList = new List<int>();
        int[] num = new int[100];
        public Form1()
        {
            InitializeComponent();
            OS = new OperatingSystem();
            rbFIFO.Checked = true;
           
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Start();
            listBox1.Items.Clear();
            myList.Clear();
            num = OS.performDiskSchedule;
 
            foreach (int i in num)
            {
                listBox1.Items.Add(i);

                myList.Add(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (doneSignal == false)
            {
                if (currentValue == trackBar1.Value)
                {
                    doneSignal = true;
                }
                else if(currentValue != trackBar1.Value)
                {
                    if (currentValue < trackBar1.Value)
                    {
                        trackBar1.Value--;
                    }
                    else if (currentValue > trackBar1.Value)
                    {
                        trackBar1.Value++;
                    }
                }
            }
            else if(doneSignal == true)
            {
                currentValue = myList.ElementAt(0);
                myList.Remove(currentValue);
                listBox1.Items.Remove(currentValue);
                myList.Add(currentValue);
                listBox1.Items.Add(currentValue);
                doneSignal = false;
                textBox1.Text = currentValue.ToString();
                   
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.listBox1.Items.Clear();
            this.textBox1.Clear();
            OS.dkSchedule = null;
            
            this.trackBar1.Value = 0;
        }

        private void rbFIFO_CheckedChanged(object sender, EventArgs e)
        {
            rbSST.Checked = false;
            rbSCAN.Checked = false;
            btnStop.PerformClick();
            
            OS.dkSchedule = new FIFO();
            btnRun.PerformClick();
        }

        private void rbSST_CheckedChanged(object sender, EventArgs e)
        {
            rbFIFO.Checked = false;
            rbSCAN.Checked = false;
            btnStop.PerformClick();
            OS.dkSchedule = new ShortestSeekTime();
            
            btnRun.PerformClick();
        }

        private void rbSCAN_CheckedChanged(object sender, EventArgs e)
        {
            rbFIFO.Checked = false;
            rbSST.Checked = false;
            btnStop.PerformClick();
            OS.dkSchedule = new SCAN();
            btnRun.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

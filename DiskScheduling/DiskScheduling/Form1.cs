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
        bool doneSignal = false;
        int currentValue;
        List<int> myList = new List<int>();
       
        int[] num = new int[100];
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         timer1.Start();
                        listBox1.Items.Clear();
                        num = OS.performDiskSchedule();
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
                doneSignal = false;
                textBox1.Text = currentValue.ToString();
            }
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.listBox1.Items.Clear();
            this.textBox1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            button2.PerformClick();
            d = new FIFO();
            OS = new OperatinSystem(d);
            button1.PerformClick();
           
           
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            button2.PerformClick();
            d = new ShortestSeekTime();
            OS = new OperatinSystem(d);
            button1.PerformClick();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button2.PerformClick();
            d = new SCAN();
            OS = new OperatinSystem(d);
            button1.PerformClick();

        }
    }
}

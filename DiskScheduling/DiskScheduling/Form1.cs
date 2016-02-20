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
                listBox1.Items.Clear();
                num = OS.performDiskSchedule();
                foreach (int i in num)
                {
                    listBox1.Items.Add(i);
                    myList.Add(i);

                }
            }
            else { if (radioButton2.Checked)
                {
                    d = new ShortestSeekTime();
                    OS = new OperatinSystem(d);
                    timer1.Start();
                    listBox1.Items.Clear();
                    num = OS.performDiskSchedule();
                    foreach (int i in num)
                    {
                        listBox1.Items.Add(i);
                        myList.Add(i);

                    }
                }
                else {  if (radioButton3.Checked)
                    {
                        d = new SCAN();
                        OS = new OperatinSystem(d);
                        timer1.Start();
                        listBox1.Items.Clear();
                        num = OS.performDiskSchedule();
                        foreach (int i in num)
                        {
                            listBox1.Items.Add(i);
                            myList.Add(i);


                        }
                    }
                }
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicTransportationApp
{
    public partial class Form1 : Form
    {
        TrafficMonitor tr;
        Train initTrain;
        Bus initBus;
        Tram initTram;
        List<Train> myTrain;
        List<Bus> myBus;
        List<Tram> myTram;
        Traffic T;
        public Form1()
        {
            InitializeComponent();
            tr = new TrafficMonitor();
            myTrain = new List<Train>();
            myBus = new List<Bus>();
            myTram = new List<Tram>();
            timer1.Interval = 20000;

            initTrain = new Train("Eindhoven", "Utrecht", 12, 31, 2);
            T = new Traffic(initTrain);
            myTrain.Add(initTrain);

            initBus =new Bus("Eindhoven", "Prague", 17, 45, 0);
            T = new Traffic(initBus);
            myBus.Add(initBus);
            
            initTram =new Tram("Best", "Neuen", 14, 22, 3);
            T = new Traffic(initTram);
            myTram.Add(initTram);
           

            lbtrainDestination.Items.Add(initTrain.From + " --> " + initTrain.To);
            lbtrainTime.Items.Add(initTrain.Hour + " : " + initTrain.Minutes);
            lbtrainDelay.Items.Add(initTrain.Delay);

            lbbusDestination.Items.Add(initBus.From + " --> " + initBus.To);
            lbbusTime.Items.Add(initBus.Hour + " : " + initBus.Minutes);
            lbbusDelay.Items.Add(initBus.Delay);

            lbtramDestination.Items.Add(initTram.From + " --> " + initTram.To);
            lbtramTime.Items.Add(initTram.Hour + " : " + initTram.Minutes);
            lbtramDelay.Items.Add(initTram.Delay);

            cbBus.Checked = true;
            cbTrain.Checked = true;
            cbTram.Checked = true;
        }
        public void AddTransportation(IPublicTransportation myTransport)
        {
            if (myTransport is Train)
            {
                lbtrainDestination.Items.Add(myTransport.From + " --> " + myTransport.To);
                lbtrainTime.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                lbtrainDelay.Items.Add(myTransport.Delay);
                myTrain.Add(myTransport as Train);
                

            }
            if(myTransport is Bus)
            {
                lbbusDestination.Items.Add(myTransport.From + " --> " + myTransport.To);
                lbbusTime.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                lbbusDelay.Items.Add(myTransport.Delay);
                myBus.Add(myTransport as Bus);


            }
            if (myTransport is Tram)
            {
                lbtramDestination.Items.Add(myTransport.From + " --> " + myTransport.To);
                lbtramTime.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                lbtramDelay.Items.Add(myTransport.Delay);
                myTram.Add(myTransport as Tram);
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addForm myForm = new addForm(this);
            myForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbtramDestination.SelectedItem != null)
            {
                lbtramTime.Items.RemoveAt(lbtramDestination.SelectedIndex);
                lbtramDelay.Items.RemoveAt(lbtramDestination.SelectedIndex);
                myTram.RemoveAt(lbtramDestination.SelectedIndex);
                lbtramDestination.Items.Remove(lbtramDestination.SelectedItem);

               
                
            }
            if (lbtrainDestination.SelectedItem != null)
            {
                lbtrainTime.Items.RemoveAt(lbtrainDestination.SelectedIndex);
                lbtrainDelay.Items.RemoveAt(lbtrainDestination.SelectedIndex);
                myTrain.RemoveAt(lbtrainDestination.SelectedIndex);
                lbtrainDestination.Items.Remove(lbtrainDestination.SelectedItem);
            }
            if (lbbusDestination.SelectedItem != null)
            {
                lbbusTime.Items.RemoveAt(lbbusDestination.SelectedIndex);
                lbbusDelay.Items.RemoveAt(lbbusDestination.SelectedIndex);
                myBus.RemoveAt(lbbusDestination.SelectedIndex);
                lbbusDestination.Items.Remove(lbbusDestination.SelectedItem);

            }
        }

        private void trainDestinationlbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lbbusDestination.SelectedItems != null && lbtramDestination.SelectedItem != null) || (lbbusDestination.SelectedItems != null || lbtramDestination.SelectedItem != null) )
            {
                lbbusDestination.SelectedItem = null;
                lbtramDestination.SelectedItem = null;
                lbtrainTime.SelectedIndex = lbtrainDestination.SelectedIndex;
                lbtrainDelay.SelectedIndex = lbtrainDestination.SelectedIndex;
            }
        }

        private void busDestinationlbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lbtrainDestination.SelectedItems != null && lbtramDestination.SelectedItem != null) || (lbtrainDestination.SelectedItems != null || lbtramDestination.SelectedItem != null))
            {
                lbtrainDestination.SelectedItem = null;
                lbtramDestination.SelectedItem = null;
                lbbusTime.SelectedIndex = lbbusDestination.SelectedIndex;
                lbbusDelay.SelectedIndex = lbbusDestination.SelectedIndex;
            }
        }

        private void tramDestinationlbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((lbtrainDestination.SelectedItems != null && lbbusDestination.SelectedItem != null) || (lbtrainDestination.SelectedItems != null || lbbusDestination.SelectedItem != null))
            {
                lbtrainDestination.SelectedItem = null;
                lbbusDestination.SelectedItem = null;
                lbtramTime.SelectedIndex = lbtramDestination.SelectedIndex;
                lbtramDelay.SelectedIndex = lbtramDestination.SelectedIndex;
            }
        }
        
        private void btnAddDelay_Click(object sender, EventArgs e)
        {
           
            if (lbtramDestination.SelectedItem != null)
            {
                int index = Convert.ToInt32(lbtramDestination.SelectedIndex);
                int delay = Convert.ToInt32(delayTextbox.Text);
                Tram tr = myTram.ElementAt(index);
                tr.DelayTram(tr, tr.Delay+delay);
                lbtramDelay.Items.RemoveAt(lbtramDestination.SelectedIndex);
                lbtramDelay.Items.Add(tr.Delay);

            }
            if (lbtrainDestination.SelectedItem != null)
            {
                int index = Convert.ToInt32(lbtrainDestination.SelectedIndex);
                int delay = Convert.ToInt32(delayTextbox.Text);
                Train t = myTrain.ElementAt(index);
                t.DelayTrain(t, t.Delay+delay);
                lbtrainDelay.Items.RemoveAt(lbtrainDestination.SelectedIndex);
                lbtrainDelay.Items.Add(t.Delay);


            }
            if (lbbusDestination.SelectedItem != null)
            {
                int index = Convert.ToInt32(lbbusDestination.SelectedIndex);
                int delay = Convert.ToInt32(delayTextbox.Text);
                Bus b = myBus.ElementAt(index);
                b.DelayBus(b, b.Delay+delay);
                lbbusDelay.Items.RemoveAt(lbbusDestination.SelectedIndex);
                lbbusDelay.Items.Add(b.Delay);

                
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (cbBus.Checked)
            {
                foreach (Bus b in myBus)
                {
                    initBus.AddBus(b);
                }
                this.lbbusDestination.Show();
                this.lbbusDelay.Show();
                this.lbbusTime.Show();
            }
            else
            {
                foreach (Bus b in myBus)
                {
                    initBus.RemoveBus(b);
                }
                this.lbbusDestination.Hide();
                this.lbbusDelay.Hide();
                this.lbbusTime.Hide();
            }
            if (cbTrain.Checked)
            {
                foreach (Train t in myTrain)
                {
                    initTrain.AddTrain(t);
                }
                this.lbtrainDestination.Show();
                this.lbtrainDelay.Show();
                this.lbtrainTime.Show();
            }
            else
            {
                foreach (Train t in myTrain)
                {
                    initTrain.RemoveTrain(t);
                }
                this.lbtrainDestination.Hide();
                this.lbtrainDelay.Hide();
                this.lbtrainTime.Hide();
            }
            if (cbTram.Checked)
            {
                foreach(Tram t in myTram)
                {
                    initTram.AddTram(t);
                }
                this.lbtramDestination.Show();
                this.lbtramDelay.Show();
                this.lbtramTime.Show();
            }
            else
            {
                foreach (Tram t in myTram)
                {
                    initTram.RemoveTram(t);
                }
                this.lbtramDestination.Hide();
                this.lbtramDelay.Hide();
                this.lbtramTime.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval += 5000;
            if (myTram.Count != 0)
            {
                lbtramTime.Items.RemoveAt(0);
                lbtramDelay.Items.RemoveAt(0);
                myTram.RemoveAt(0);
                lbtramDestination.Items.RemoveAt(0);
            }
            if
               (myTrain.Count != 0)
            {
                lbtrainTime.Items.RemoveAt(0);
                lbtrainDelay.Items.RemoveAt(0);
                myTrain.RemoveAt(0);
                lbtrainDestination.Items.RemoveAt(0);
            }
            if (myBus.Count != 0)
            {
                lbbusTime.Items.RemoveAt(0);
                lbbusDelay.Items.RemoveAt(0);
                myBus.RemoveAt(0);
                lbbusDestination.Items.RemoveAt(0);
            }

        }

        private void BtnStopTimer_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
    }


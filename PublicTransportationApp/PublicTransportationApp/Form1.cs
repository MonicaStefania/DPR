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
            myTrain.Add(initTrain);
            initTrain.Attach(new Traffic(initTrain as Train));


            initBus = new Bus("Eindhoven", "Prague", 17, 45, 0);
            myBus.Add(initBus);
            initBus.Attach(new Traffic(initBus as Bus));

            initTram = new Tram("Best", "Neuen", 14, 22, 3);
            myTram.Add(initTram);
            initTram.Attach(new Traffic(initTram as Tram));


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
                lbtrainDestination.Items.Add(((Train)myTransport).From + " --> " + ((Train)myTransport).To);
                lbtrainTime.Items.Add(((Train)myTransport).Hour + " : " + ((Train)myTransport).Minutes);
                lbtrainDelay.Items.Add(((Train)myTransport).Delay);
               myTransport.Attach(new Traffic(myTransport as Train));

                myTrain.Add(myTransport as Train);

            }
            if(myTransport is Bus)
            {
                lbbusDestination.Items.Add(((Bus)myTransport).From + " --> " + ((Bus)myTransport).To);
                lbbusTime.Items.Add(((Bus)myTransport).Hour + " : " + ((Bus)myTransport).Minutes);
                lbbusDelay.Items.Add(((Bus)myTransport).Delay);
                myTransport.Attach( new Traffic(myTransport as Bus));

                myBus.Add(myTransport as Bus);


            }
            if (myTransport is Tram)
            {
                lbtramDestination.Items.Add(((Tram)myTransport).From + " --> " + ((Tram)myTransport).To);
                lbtramTime.Items.Add(((Tram)myTransport).Hour + " : " + ((Tram)myTransport).Minutes);
                lbtramDelay.Items.Add(((Tram)myTransport).Delay);
                myTransport.Attach(new Traffic(myTransport as Tram));

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
                myTram.ElementAt(lbtramDestination.SelectedIndex).Detach(T);
                lbtramTime.Items.RemoveAt(lbtramDestination.SelectedIndex);
                lbtramDelay.Items.RemoveAt(lbtramDestination.SelectedIndex);
                initTram.RemoveTram(myTram.ElementAt(lbtramDestination.SelectedIndex));
                myTram.RemoveAt(lbtramDestination.SelectedIndex);
                lbtramDestination.Items.Remove(lbtramDestination.SelectedItem);

            }
            if (lbtrainDestination.SelectedItem != null)
            {
                myTrain.ElementAt(lbtrainDestination.SelectedIndex).Detach(T);

                lbtrainTime.Items.RemoveAt(lbtrainDestination.SelectedIndex);
                lbtrainDelay.Items.RemoveAt(lbtrainDestination.SelectedIndex);
                initTrain.RemoveTrain(myTrain.ElementAt(lbtrainDestination.SelectedIndex));

                myTrain.RemoveAt(lbtrainDestination.SelectedIndex);
                lbtrainDestination.Items.Remove(lbtrainDestination.SelectedItem);


            }
            if (lbbusDestination.SelectedItem != null)
            {
                myBus.ElementAt(lbbusDestination.SelectedIndex).Detach(T);
                lbbusTime.Items.RemoveAt(lbbusDestination.SelectedIndex);
                lbbusDelay.Items.RemoveAt(lbbusDestination.SelectedIndex);
                initBus.RemoveBus(myBus.ElementAt(lbbusDestination.SelectedIndex));

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
                    b.AddBus(b);
                    b.Attach(new Traffic(b));
                }
                this.lbbusDestination.Show();
                this.lbbusDelay.Show();
                this.lbbusTime.Show();

            }
            else
            {
                foreach (Bus b in myBus)
                {
                    b.RemoveBus(b);
                    b.Detach(new Traffic(b));

                }
                this.lbbusDestination.Hide();
                this.lbbusDelay.Hide();
                this.lbbusTime.Hide();
            }
            if (cbTrain.Checked)
            {
                foreach (Train t in myTrain)
                {
                    t.AddTrain(t);
                    t.Attach(new Traffic(t));

                }
                this.lbtrainDestination.Show();
                this.lbtrainDelay.Show();
                this.lbtrainTime.Show();
            }
            else
            {
                foreach (Train t in myTrain)
                {
                    t.RemoveTrain(t);
                    t.Detach(new Traffic(t));

                }
                this.lbtrainDestination.Hide();
                this.lbtrainDelay.Hide();
                this.lbtrainTime.Hide();
            }
            if (cbTram.Checked)
            {
                foreach(Tram t in myTram)
                {
                    t.AddTram(t);
                    t.Attach(new Traffic(t));

                }
                this.lbtramDestination.Show();
                this.lbtramDelay.Show();
                this.lbtramTime.Show();
            }
            else
            {
                foreach (Tram t in myTram)
                {
                    t.RemoveTram(t);
                    t.Detach(new Traffic(t));
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
                this.lbtramDestination.SetSelected(0, true);
                btnRemove.PerformClick();

                //lbtramTime.Items.RemoveAt(0);
                //lbtramDelay.Items.RemoveAt(0);
                //myTram.RemoveAt(0);
                //lbtramDestination.Items.RemoveAt(0);
            }
            if
               (myTrain.Count != 0)
            {
                this.lbtrainDestination.SetSelected(0, true);
                btnRemove.PerformClick();

                //lbtrainTime.Items.RemoveAt(0);
                //lbtrainDelay.Items.RemoveAt(0);
                //myTrain.RemoveAt(0);
                //lbtrainDestination.Items.RemoveAt(0);
            }
            if (myBus.Count != 0)
            {
                this.lbbusDestination.SetSelected(0, true);
                btnRemove.PerformClick();

                //lbbusTime.Items.RemoveAt(0);
                //lbbusDelay.Items.RemoveAt(0);
                //myBus.RemoveAt(0);
                //lbbusDestination.Items.RemoveAt(0);
            }

        }

        private void BtnStopTimer_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.lblInfoTimer.Text = "timer stopped";

        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.lblInfoTimer.Text = "timer started";
        }
    }
    }


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

            initTrain = new Train("Eindhoven", "Utrecht", 12, 31, 2);
            T = new Traffic(initTrain);
            myTrain.Add(initTrain);
            //this is how it has to look everytime u add an element.
            initBus =new Bus("Eindhoven", "Prague", 17, 45, 0);
            T = new Traffic(initBus);
            myBus.Add(initBus);
            
            initTram =new Tram("Best", "Neuen", 14, 22, 3);
            T = new Traffic(initTram);
            myBus.Add(initBus);
           

            trainDestinationlbox.Items.Add(initTrain.From + " --> " + initTrain.To);
            trainTimelbox.Items.Add(initTrain.Hour + " : " + initTrain.Minutes);
            trainDelaylbox.Items.Add(initTrain.Delay);
            myTrain.Add(initTrain);

            busDestinationlbox.Items.Add(initBus.From + " --> " + initBus.To);
            busTimelbox.Items.Add(initBus.Hour + " : " + initBus.Minutes);
            busDelaylbox.Items.Add(initBus.Delay);
            myBus.Add(initBus);

            tramDestinationlbox.Items.Add(initTram.From + " --> " + initTram.To);
            tramTimelbox.Items.Add(initTram.Hour + " : " + initTram.Minutes);
            tramDelaylbox.Items.Add(initTram.Delay);
            myTram.Add(initTram);

            cbBus.Checked = true;
            cbTrain.Checked = true;
            cbTram.Checked = true;
        }
        public void AddTransportation(IPublicTransportation myTransport)
        {
            if (myTransport is Train)
            {
                trainDestinationlbox.Items.Add(myTransport.From + " --> " + myTransport.To);
                trainTimelbox.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                trainDelaylbox.Items.Add(myTransport.Delay);
                myTrain.Add(myTransport as Train);
                
                //T = new Traffic(myTransport as Train);

            }
            if(myTransport is Bus)
            {
                busDestinationlbox.Items.Add(myTransport.From + " --> " + myTransport.To);
                busTimelbox.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                busDelaylbox.Items.Add(myTransport.Delay);
               // myBus.Add(myTransport as Bus);


            }
            if (myTransport is Tram)
            {
                tramDestinationlbox.Items.Add(myTransport.From + " --> " + myTransport.To);
                tramTimelbox.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                tramDelaylbox.Items.Add(myTransport.Delay);
               // myTram.Add(myTransport as Tram);
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addForm myForm = new addForm(this);
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tramDestinationlbox.SelectedItem != null)
            {
                tramTimelbox.Items.RemoveAt(tramDestinationlbox.SelectedIndex);
                tramDelaylbox.Items.RemoveAt(tramDestinationlbox.SelectedIndex);
                myTram.RemoveAt(tramDestinationlbox.SelectedIndex);
                tramDestinationlbox.Items.Remove(tramDestinationlbox.SelectedItem);

               
                
            }
            if (trainDestinationlbox.SelectedItem != null)
            {
                trainTimelbox.Items.RemoveAt(trainDestinationlbox.SelectedIndex);
                trainDelaylbox.Items.RemoveAt(trainDestinationlbox.SelectedIndex);
                myTrain.RemoveAt(trainDestinationlbox.SelectedIndex);
                trainDestinationlbox.Items.Remove(trainDestinationlbox.SelectedItem);
            }
            if (busDestinationlbox.SelectedItem != null)
            {
                busTimelbox.Items.RemoveAt(busDestinationlbox.SelectedIndex);
                busDelaylbox.Items.RemoveAt(busDestinationlbox.SelectedIndex);
                myBus.RemoveAt(busDestinationlbox.SelectedIndex);
                busDestinationlbox.Items.Remove(busDestinationlbox.SelectedItem);

            }
        }

        private void trainDestinationlbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((busDestinationlbox.SelectedItems != null && tramDestinationlbox.SelectedItem != null) || (busDestinationlbox.SelectedItems != null || tramDestinationlbox.SelectedItem != null) )
            {
                busDestinationlbox.SelectedItem = null;
                tramDestinationlbox.SelectedItem = null;
                trainTimelbox.SelectedIndex = trainDestinationlbox.SelectedIndex;
                trainDelaylbox.SelectedIndex = trainDestinationlbox.SelectedIndex;
            }
        }

        private void busDestinationlbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((trainDestinationlbox.SelectedItems != null && tramDestinationlbox.SelectedItem != null) || (trainDestinationlbox.SelectedItems != null || tramDestinationlbox.SelectedItem != null))
            {
                trainDestinationlbox.SelectedItem = null;
                tramDestinationlbox.SelectedItem = null;
                busTimelbox.SelectedIndex = busDestinationlbox.SelectedIndex;
                busDelaylbox.SelectedIndex = busDestinationlbox.SelectedIndex;
            }
        }

        private void tramDestinationlbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((trainDestinationlbox.SelectedItems != null && busDestinationlbox.SelectedItem != null) || (trainDestinationlbox.SelectedItems != null || busDestinationlbox.SelectedItem != null))
            {
                trainDestinationlbox.SelectedItem = null;
                busDestinationlbox.SelectedItem = null;
                tramTimelbox.SelectedIndex = tramDestinationlbox.SelectedIndex;
                tramDelaylbox.SelectedIndex = tramDestinationlbox.SelectedIndex;
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            // TO DO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (tramDestinationlbox.SelectedItem != null)
            {
                int index = Convert.ToInt32(tramDestinationlbox.SelectedIndex);
                int delay = Convert.ToInt32(delayTextbox.Text);
                Tram tr = myTram.ElementAt(index);
                tr.DelayTram(tr, delay);
                tramDelaylbox.Items.RemoveAt(tramDestinationlbox.SelectedIndex);
                tramDelaylbox.Items.Add(tr.Delay);

            }
            if (trainDestinationlbox.SelectedItem != null)
            {
                int index = Convert.ToInt32(trainDestinationlbox.SelectedIndex);
                int delay = Convert.ToInt32(delayTextbox.Text);
                Train t = myTrain.ElementAt(index);
                t.DelayTrain(t, delay);
                trainDelaylbox.Items.RemoveAt(trainDestinationlbox.SelectedIndex);
                trainDelaylbox.Items.Add(t.Delay);


            }
            if (busDestinationlbox.SelectedItem != null)
            {
                int index = Convert.ToInt32(busDestinationlbox.SelectedIndex);
                int delay = Convert.ToInt32(delayTextbox.Text);
                Bus b = myBus.ElementAt(index);
                b.DelayBus(b, delay);
                //busDelaylbox.Refresh(); -- I dont know why it does not refresh the delaylistbox, I;ve tried everything 
                // so I remove and add.
                busDelaylbox.Items.RemoveAt(busDestinationlbox.SelectedIndex);
                busDelaylbox.Items.Add(b.Delay);

                
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (cbBus.Checked)
            {
                //clear listbox add items to listobx
                foreach (Bus b in myBus)
                {
                    initBus.AddBus(b);
                }
            }
            else
            {
            //clear listbox
                foreach (Bus b in myBus)
                {
                    initBus.RemoveBus(b);
                }
            }
            if (cbTrain.Checked)
            {
                foreach (Train t in myTrain)
                {
                    initTrain.AddTrain(t);
                }
            }
            else
            {
                foreach (Train t in myTrain)
                {
                    initTrain.RemoveTrain(t);
                }
            }
            if (cbTram.Checked)
            {
                foreach(Tram t in myTram)
                {
                    initTram.AddTram(t);
                }
            }
            else
            {
                foreach (Tram t in myTram)
                {
                    initTram.RemoveTram(t);
                }
            }
        }
        }
    }


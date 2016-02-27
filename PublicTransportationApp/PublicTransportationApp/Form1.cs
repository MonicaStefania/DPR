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

        public Form1()
        {
            InitializeComponent();
            tr = new TrafficMonitor();
            myTrain = new List<Train>();
            myBus = new List<Bus>();
            myTram = new List<Tram>();
            initTrain = new Train("Eindhoven", "Utrecht", 12, 31, 2, true);
            initBus = new Bus("Eindhoven", "Prague", 17, 45, 0, false);
            initTram = new Tram("Best", "Neuen", 14, 22, 3, true);

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

            showTrain.Checked = true;
            showBus.Checked = true;
            showTram.Checked = true;
        }
        public void AddTransportation(IPublicTransportation myTransport)
        {
            if (myTransport is Train)
            {
                trainDestinationlbox.Items.Add(myTransport.From + " --> " + myTransport.To);
                trainTimelbox.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                trainDelaylbox.Items.Add(myTransport.Delay);
                myTrain.Add(myTransport as Train);
            }
            if(myTransport is Bus)
            {
                busDestinationlbox.Items.Add(myTransport.From + " --> " + myTransport.To);
                busTimelbox.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                busDelaylbox.Items.Add(myTransport.Delay);
                myBus.Add(myTransport as Bus);


            }
            if (myTransport is Tram)
            {
                tramDestinationlbox.Items.Add(myTransport.From + " --> " + myTransport.To);
                tramTimelbox.Items.Add(myTransport.Hour + " : " + myTransport.Minutes);
                tramDelaylbox.Items.Add(myTransport.Delay);
                myTram.Add(myTransport as Tram);
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
              
                
                


            }
            if (trainDestinationlbox.SelectedItem != null)
            {
                trainTimelbox.Items.RemoveAt(trainDestinationlbox.SelectedIndex);
                trainDelaylbox.Items.RemoveAt(trainDestinationlbox.SelectedIndex);
                trainDestinationlbox.Items.Remove(trainDestinationlbox.SelectedItem);
            }
            if (busDestinationlbox.SelectedItem != null)
            {
                busTimelbox.Items.RemoveAt(busDestinationlbox.SelectedIndex);
                busDelaylbox.Items.RemoveAt(busDestinationlbox.SelectedIndex);
                busDestinationlbox.Items.Remove(busDestinationlbox.SelectedItem);

            }
        }
    }
}

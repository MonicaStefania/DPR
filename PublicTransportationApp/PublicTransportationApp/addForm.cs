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
    public partial class addForm : Form
    {
        Form1 myForm;
        public addForm(Form1 f)
        {
            InitializeComponent();
            myForm = f;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IPublicTransportation myTransport;
            if (trainRadioButton.Checked)
            {
                Train ty = new Train(fromTextBox.Text, toTextbox.Text, Convert.ToInt32(hourTextbox.Text), Convert.ToInt32(minTextbox.Text), Convert.ToInt32(delayTextbox.Text), true);
                myTransport = ty;
            }
           else if (busRadioButton.Checked)
            {
                Bus tz = new Bus(fromTextBox.Text, toTextbox.Text, Convert.ToInt32(hourTextbox.Text), Convert.ToInt32(minTextbox.Text), Convert.ToInt32(delayTextbox.Text), true);
                myTransport = tz;
            }
            else 
            {
                Tram ta = new Tram(fromTextBox.Text, toTextbox.Text, Convert.ToInt32(hourTextbox.Text), Convert.ToInt32(minTextbox.Text), Convert.ToInt32(delayTextbox.Text), true);
                myTransport = ta;
            }
            myForm.AddTransportation(myTransport);
            this.Close();
        }
    }
}

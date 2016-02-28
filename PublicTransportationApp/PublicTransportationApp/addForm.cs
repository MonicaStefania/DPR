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
        private void btnSend_Click(object sender, EventArgs e)
        {
            IPublicTransportation myTransport;
            if (rbTrain.Checked)
            {
                Train ty = new Train(tbFrom.Text, tbTo.Text, Convert.ToInt32(tbHour.Text), Convert.ToInt32(tbMin.Text), Convert.ToInt32(tbDelay.Text));
                myTransport = ty;
            }
           else if (rbBus.Checked)
            {
                Bus tz = new Bus(tbFrom.Text, tbTo.Text, Convert.ToInt32(tbHour.Text), Convert.ToInt32(tbMin.Text), Convert.ToInt32(tbDelay.Text));
                myTransport = tz;
            }
            else 
            {
                Tram ta = new Tram(tbFrom.Text, tbTo.Text, Convert.ToInt32(tbHour.Text), Convert.ToInt32(tbMin.Text), Convert.ToInt32(tbDelay.Text));
                myTransport = ta;
            }
            myForm.AddTransportation(myTransport);
            this.Close();
        }

    
    }
}

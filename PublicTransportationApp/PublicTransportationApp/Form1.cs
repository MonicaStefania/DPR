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
        

        public Form1()
        {
            InitializeComponent();
            tr = new TrafficMonitor();
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

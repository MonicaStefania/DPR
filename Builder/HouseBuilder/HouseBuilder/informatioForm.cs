using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseBuilder
{
    public partial class informatioForm : Form
    {
        informatioForm myForm;
        public informatioForm()
        {
            InitializeComponent();
             myForm = new informatioForm();
        }
        public void fillhouseInformation(string info)
        {

            labelInformation.Text = info;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            myForm.Close();
            
        }
    }
}

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
    public partial class Form1 : Form
    {
        informatioForm infoForm;
        ArchitectDirector architect;
        public Form1()
        {
            
            InitializeComponent();
            infoForm = new informatioForm();
            architect = new ArchitectDirector();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFamilyBuild_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btnFamilyInfo_Click(object sender, EventArgs e)
        {
            
            IHouseBuilder familyHouse = new FamilyHousebuilder();
            architect.BuildHouse(familyHouse);
            House myHouse = familyHouse.GetHouse();
            infoForm.fillhouseInformation(myHouse.ToString());
            infoForm.Show();
        }

        private void btnCabinInfo_Click(object sender, EventArgs e)
        {
            IHouseBuilder cabinHouse = new CabinHouseBuilder();
            architect.BuildHouse(cabinHouse);
            House cHouse = cabinHouse.GetHouse();
            infoForm.fillhouseInformation(cHouse.ToString());
            infoForm.Show();
        }
    }
}

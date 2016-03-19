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
        
        ArchitectDirector architect;
        public Form1()
        {
            
            InitializeComponent();
            
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
            if (rbtnF.Checked)
            {
                IHouseBuilder familyHouse = new FamilyHousebuilder();
                architect.BuildHouse(familyHouse);
                House myHouse = familyHouse.GetHouse();
                lbInfo.Text = myHouse.ToString();
                //thePicture.Image = Properties.Resources.;
                thePicture.Refresh();
                thePicture.Visible = true;
            }
            if (rbtnCabin.Checked)
            {
                IHouseBuilder cabinHouse = new CabinHouseBuilder();
                architect.BuildHouse(cabinHouse);
                House cHouse = cabinHouse.GetHouse();
                lbInfo.Text = cHouse.ToString();

            }
            if (rbtnCountry.Checked)
            {
                IHouseBuilder countryHouse = new CountryHouseBuilder();
                architect.BuildHouse(countryHouse);
                House cabHouse = countryHouse.GetHouse();
                lbInfo.Text = cabHouse.ToString();
            }
            else if (rbtnVacantion.Checked) {
                IHouseBuilder vacHouse = new VacationHouseBuilder();
                architect.BuildHouse(vacHouse);
                House vacantionHouse = vacHouse.GetHouse();
                lbInfo.Text = vacantionHouse.ToString();
            }


        }

        private void btnFamilyInfo_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void btnCabinInfo_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}

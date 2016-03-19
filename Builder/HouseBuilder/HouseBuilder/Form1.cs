using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace HouseBuilder
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer myPlayer;
        ArchitectDirector architect;
        public Form1()
        {
            
            InitializeComponent();
            
            architect = new ArchitectDirector();
            this.thePicture.Visible = false;
            myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = "../../Resources/alert.wav";
           
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

                thePicture.Image = Properties.Resources.family_house;
                thePicture.Refresh();
                thePicture.Visible = true;
                
            }
            if (rbtnCabin.Checked)
            {
                IHouseBuilder cabinHouse = new CabinHouseBuilder();
                architect.BuildHouse(cabinHouse);
                House cHouse = cabinHouse.GetHouse();
                lbInfo.Text = cHouse.ToString();


                thePicture.Image = Properties.Resources.cabin_house;
                thePicture.Refresh();
                thePicture.Visible = true;

            }
            if (rbtnCountry.Checked)
            {
                IHouseBuilder countryHouse = new CountryHouseBuilder();
                architect.BuildHouse(countryHouse);
                House cabHouse = countryHouse.GetHouse();
                lbInfo.Text = cabHouse.ToString();

                thePicture.Image = Properties.Resources.country_house;
                thePicture.Refresh();
                thePicture.Visible = true;
            }
            else if (rbtnVacantion.Checked) {
                IHouseBuilder vacHouse = new VacationHouseBuilder();
                architect.BuildHouse(vacHouse);
                House vacantionHouse = vacHouse.GetHouse();
                lbInfo.Text = vacantionHouse.ToString();

                thePicture.Image = Properties.Resources.vacantion_house;
                thePicture.Refresh();
                thePicture.Visible = true;
            }
            myPlayer.Play();



        }

        private void btnFamilyInfo_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void btnCabinInfo_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}

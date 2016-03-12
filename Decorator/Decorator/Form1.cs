using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        ICharacter c;
        public Form1()
        {
            InitializeComponent();
            rbMage.Checked = false;
            rbWarrior.Checked = false;
            this.lbAvailableOptions.Items.Add("Weapon");
            this.lbAvailableOptions.Items.Add("Shield");
            this.lbAvailableOptions.Items.Add("Armor");
            this.lbAvailableOptions.Items.Add("PVP Gear");
            this.lbAvailableOptions.Items.Add("Damge Poion");
            this.lbAvailableOptions.Items.Add("Intellignce scroll");


        }

        private void rbWarrior_CheckedChanged(object sender, EventArgs e)
        {
            c = new Warrior();
            this.lblPrice.Text ="Price: " + c.Price().ToString();
            this.lblIntelligence.Text = "Intelligence "+c.Intelligence().ToString();
            this.lblDamage.Text = "Damage "+c.Damage().ToString();
            
            this.pictureBox1.Image = Properties.Resources.warrior;

        }

        private void rbMage_CheckedChanged(object sender, EventArgs e)
        {
            c = new Mage();
            this.lblPrice.Text = "Price: " + c.Price().ToString();
            this.lblIntelligence.Text = "Intelligence " + c.Intelligence().ToString();
            this.lblDamage.Text = "Damage " + c.Damage().ToString();
            this.pictureBox1.Image = Properties.Resources.mage;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.lbAddedOptions.Items.Add(Convert.ToString(this.lbAvailableOptions.SelectedItem));
           
                switch (lbAvailableOptions.SelectedItem.ToString())
                {
                    case "Weapon":
                    this.lblDamage.Text = "Damage " + new AddWeapon(null).getDamage();
                    this.lblIntelligence.Text = "Intelligence " + new AddWeapon(null).getIntelligence();
                    this.lblPrice.Text = "Price: " + new AddWeapon(null).getPrice()+ " gold";
                        break;
                    case "Intelligence scroll":
                    this.lblDamage.Text = "Damage " + new AddScrolls(null).getDamage();
                    this.lblIntelligence.Text = "Intelligence " + new AddScrolls(null).getIntelligence(); ;
                    this.lblPrice.Text = "Price: " + new AddScrolls(null).getPrice() + " gold";
                        break;
                    case "Armor":
                    this.lblDamage.Text = "Damage " + new AddArmor(null).getDamage();
                    this.lblIntelligence.Text = "Intelligence " + new AddArmor(null).getIntelligence(); ;
                    this.lblPrice.Text = "Price: " + new AddArmor(null).getPrice() + " gold";
                    break;
                    case "Damage potion":
                    this.lblDamage.Text = "Damage " + new AddDamagePotions(null).getDamage();
                    this.lblIntelligence.Text = "Intelligence " + new AddDamagePotions(null).getIntelligence() ;
                    this.lblPrice.Text = "Price: " + new AddScrolls(null).getPrice() + " gold";
                    break;
                    case "PVP gear":
                    this.lblDamage.Text = "Damage " + new AddPVPGear(null).getDamage();
                    this.lblIntelligence.Text = "Intelligence " + new AddPVPGear(null).getIntelligence();
                    this.lblPrice.Text = "Price: " + new AddPVPGear(null).getPrice() + " gold";
                    break;
                    case "Shield":
                    this.lblDamage.Text = "Damage " + new AddShield(null).getDamage();
                    this.lblIntelligence.Text = "Intelligence " + new AddShield(null).getIntelligence();
                    this.lblPrice.Text = "Price: " + new AddShield(null).getPrice() + " gold";
                    break;
                }

            }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (string s in lbAddedOptions.Items)
            {
                switch (s)
                {
                    case "Weapon":
                        c = new AddWeapon(c);
                        break;
                    case "Intelligence scroll":
                        c = new AddScrolls(c);
                        break;
                    case "Armor":
                        c = new AddArmor(c);
                        break;
                    case "Damage potion":
                        c = new AddDamagePotions(c);
                        break;
                    case "PVP gear":
                        c = new AddPVPGear(c);
                        break;
                    case "Shield":
                        c = new AddShield(c);
                        break;
                }

            }
            this.lblInfo.Text = "Character purchased for " + lblPrice.Text + c.Description() + lblDamage.Text + lblIntelligence.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}

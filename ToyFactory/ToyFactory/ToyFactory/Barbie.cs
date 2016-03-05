using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace ToyFactory
{
    [Serializable]
    class Barbie : IDolls, IFigure
    {
        public String Name { get; set; }
        public Barbie(String name)
        {
            this.Name = name;
            this.Avatar = Properties.Resources.barbieini;
            this.Age = 15;

        }
    
        public Image Avatar { get; set; }

        public int Age { get; set; }

        public void cry()
        {
            this.Avatar = Properties.Resources.barbiecrying;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/barbie_cry.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }

        public void eat()
        {
            this.Avatar = Properties.Resources.barbieeating;
         
        }

        public void jump()
        {
            this.Avatar = Properties.Resources.barbiejump;
        }

        public void play()
        {
            this.Avatar = Properties.Resources.barbieplay;
        }

        public void sleep()
        {
            this.Avatar = Properties.Resources.barbiesleeping;
        }

        public void talk()
        {
            this.Avatar = Properties.Resources.barbietalk;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/barbie_talk.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }
    }
}

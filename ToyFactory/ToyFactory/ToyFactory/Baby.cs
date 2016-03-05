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
    class Baby : IDolls, IFigure
    {
        private String Name{get;set;}
        public Baby(String name)
        {
            this.Name = name;
           this.Avatar = Properties.Resources.initialbabay;
        }
        public Image getAvatar()
        {
            return this.Avatar;
        }
        public Image Avatar { get; set; }
        public void cry()
        {
            this.Avatar = Properties.Resources.babycry;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/baby_crying.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }

        }

        public void eat()
        {
            this.Avatar = Properties.Resources.babyeating;
        }

        public void jump()
        {
            this.Avatar = Properties.Resources.babyjumping;
        }

        public void play()
        {
            this.Avatar = Properties.Resources.babyplay;
        }

        public void sleep()
        {
            this.Avatar = Properties.Resources.babysleeping;        }

        public void talk()

        {
            this.Avatar = Properties.Resources.babytalk;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/baby_talking.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }
    }
}

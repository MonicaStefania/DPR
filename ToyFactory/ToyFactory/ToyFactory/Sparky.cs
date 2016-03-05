using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ToyFactory
{[Serializable]

    class Sparky : IPets, IFigure
    {
        public String Name { get; set; }
        public Image Avatar { get; set; }

        public string Owner
        {
            get; set;
        }

        public Sparky(String name)
        {
            this.Name = name;
            this.Avatar = Properties.Resources.sparkyinitial;
            this.Owner = "user";
        }
        public void cry()
        {
            this.Avatar = Properties.Resources.crysparky;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/dog_crying.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }

        public void eat()
        {
            this.Avatar = Properties.Resources.eatingdog;
        }

        public void jump()
        {
            this.Avatar = Properties.Resources.jumpingdog;
        }

        public void play()
        {
            this.Avatar = Properties.Resources.playingdog;
        }

        public void sleep()
        {
            this.Avatar = Properties.Resources.sleepingdog;        }

        public void talk()
        {
            this.Avatar = Properties.Resources.talkingdog;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/dog_bark.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }
       
    }
}

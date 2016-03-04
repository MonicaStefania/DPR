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
    class Furby : IPets, IFigure
    {
        private String Name { get; set; }
        public Image Avatar { get; set; }
        public Furby(String name)
        {
            this.Name = name;
            this.Avatar = Properties.Resources.furbyini;
        }
        public void cry()
        {
            this.Avatar = Properties.Resources.sadfurby;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/furby.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }

        public void eat()
        {
            this.Avatar = Properties.Resources.eatingfurby;
        }

        public void jump()
        {
            this.Avatar = Properties.Resources.jumpingfurby;
        }

        public void play()
        {
            this.Avatar = Properties.Resources.playingfurby;
        }

        public void sleep()
        {
            this.Avatar = Properties.Resources.sleepingfurby;
        }

        public void talk()
        {
            this.Avatar = Properties.Resources.furby_talk;
            try
            {
                System.Media.SoundPlayer myPlayer = new System.Media.SoundPlayer();
                myPlayer.SoundLocation = "../../Sound/furby_talk.wav";
                myPlayer.Play();
            }
            catch { MessageBox.Show("Sorry, something went wrong"); }
        }
    }
}

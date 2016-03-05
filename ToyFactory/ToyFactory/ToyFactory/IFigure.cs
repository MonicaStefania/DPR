using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ToyFactory
{
    
    interface IFigure
    {
        void jump();
        void cry();
        void talk();
        void eat();
        void sleep();
        void play();
        Image Avatar { get; set; }
        String Name { get; set; }
    }
}

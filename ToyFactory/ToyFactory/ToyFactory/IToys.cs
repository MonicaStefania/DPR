using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ToyFactory
{
    interface IToys
    {
        IFigure createBoyFigure(String name);
        IFigure createGirlFigure(String name);
       
    }
}

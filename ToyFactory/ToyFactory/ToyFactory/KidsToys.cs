using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    [Serializable]
    class KidsToys : IToys
    {
        public IFigure createBoyFigure(string name)
        {
            return (new Furby(name));
        }

        public IFigure createGirlFigure(string name)
        {
            return (new Barbie(name));
        }
       
    }
}

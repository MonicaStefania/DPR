using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyFactory
{
    [Serializable]
    class InfantToys : IToys
    {
        public IFigure createBoyFigure(string name)
        {
            return (new Sparky(name));
        }

        public IFigure createGirlFigure(string name)
        {
            return (new Baby(name));
        }
        
    }
}

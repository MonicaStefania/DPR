using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class GameAdapter
    {
        IIos ios;
        GameAdapter(IIos ios) { }
        string TransmitGame(String info) { return ""; }
        string TransformGame(String info) { return ""; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class GameAdapter:IAndroid
    {
        private IIos iosPhone;
        IIos ios;
        GameAdapter(IIos ios) { this.iosPhone = ios; }
        string TransmitGame(String info) { return TransformGame(iosPhone.RunIosGame(info)); }
        string TransformGame(String info) { return "the game" + info +"can now be run on samsung"  ; }

        public string RunAndroidGame(string info)
        {
            throw new NotImplementedException();
        }
    }
}

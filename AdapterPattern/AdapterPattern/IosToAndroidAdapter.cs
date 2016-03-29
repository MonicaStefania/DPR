using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class IosToAndroidAdapter:IAndroid
    {
        private IIos iosPhone;
        public IosToAndroidAdapter(IIos ios) { this.iosPhone = ios; }
        public string ProcessGame(String info) { return "the IOS game" +  " " + info + " " + "can now be run on Android devices"  ; }

        public string RunAndroidGame(string info)
        {
            return ProcessGame(iosPhone.RunIosGame(info));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
    class Train : IPublicTransportation
    {
        List<Train> myTrains;
        
        public Train(String from, string to, int h, int min, int delay, bool isDeplayed)
        {
            this.From = from;
            this.To = to;
            this.Hour = h;
            this.Minutes = min;
            this.Delay = delay;
            this.isDelayed = isDelayed;
        }

        public int Delay { get; set; }

        public bool isDelayed { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }
      

        public void Attach(PublicTransportation obj)
        {
            myTrains.Add((Train)obj);
            Notify(obj);
        }

        public void Detach(PublicTransportation obj)
        {
            this.myTrains.Remove((Train)obj);
        }

        public void Notify(PublicTransportation obj)
        {
            if(obj.isDelayed)
            {
                //do smth
            }
        }
        public string State(PublicTransportation obj)
        {
            return "";
        }
    }
}

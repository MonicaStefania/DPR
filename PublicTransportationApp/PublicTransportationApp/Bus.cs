using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
    class Bus : IPublicTransportation
    {
        List<Bus> myBuses=new List<Bus>();
        List<IObserver> myObservers=new List<IObserver>();
        public Bus(String from, string to, int h, int min, int delay)
        {
            this.From = from;
            this.To = to;
            this.Hour = h;
            this.Minutes = min;
            this.Delay = delay;
            AddBus(this);
                    
        }

        public int Delay { get; set; }
        public bool isDelayed { get; set ; }
        public string From { get; set; }
        public string To { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }

        public void AddBus(Bus B)
        { 
            if (B.Delay > 0)
            {
                B.isDelayed = true;
            }
            else
            {
                B.isDelayed = false;
            }
           

            myBuses.Add(B);
            Notify();

        }
        public void RemoveBus(Bus b)
        {
            myBuses.Remove(b);
            Notify();
        }
        public void DelayBus(Bus b, int delay)
        {
            b.isDelayed = true;
            b.Delay = delay;
            Notify();
        }
        public string toString()
        {
            return To + " - " + From + " " + Hour + ":" + Minutes + "Delay: " + Delay;
        }
        public void Attach(IObserver o)
        {
            myObservers.Add(o);
        }

        public void Detach(IObserver o)
        {
            myObservers.Remove(o);

        }

        public void Notify()
        {

            foreach (IObserver o in myObservers)
            {
                o.Update();
            }

        }
        public bool State()
        {
            return isDelayed;
        }


    }
}

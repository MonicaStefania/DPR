using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
    class Train : IPublicTransportation
    {
        List<Train> myTrains=new List<Train>();
        List<IObserver> myObservers = new List<IObserver>();
        public Train(String from, string to, int h, int min, int delay)
        {
            this.From = from;
            this.To = to;
            this.Hour = h;
            this.Minutes = min;
            this.Delay = delay;
            AddTrain(this);
        }

        public int Delay { get; set; }
        public bool isDelayed { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }

        public void AddTrain(Train T)
        {
            if (T.Delay > 0)
            {
                T.isDelayed = true;
            }
            else
            {
                T.isDelayed = false;
                    }
                myTrains.Add(T);
            Notify();
            
        }
        public void RemoveTrain(Train t)
        {
            myTrains.Remove(t);
            Notify();
        }
        public void DelayTrain(Train t, int delay)
        {
            t.isDelayed = true;
            t.Delay = delay;
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransportationApp
{
    class Tram : IPublicTransportation
    {
        List<Tram> myTrams=new List<Tram>();
        List<IObserver> myObservers = new List<IObserver>();

        public Tram(String from, string to, int h, int min, int delay)
        {
            this.From = from;
            this.To = to;
            this.Hour = h;
            this.Minutes = min;
            this.Delay = delay;
            AddTram(this);
        }

        public int Delay { get; set; }
        public bool isDelayed { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }

        public void AddTram(Tram T)
        {
           
            if (T.Delay > 0)
            {
                T.isDelayed = true;
            }
            else
            {
                T.isDelayed = false;
            }
            myTrams.Add(T);
            Notify();

        }
        public void RemoveTram(Tram t)
        {
            myTrams.Remove(t);
            Notify();
        }
        public void DelayTram(Tram t, int delay)
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

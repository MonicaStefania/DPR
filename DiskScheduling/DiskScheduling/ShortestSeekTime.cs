using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class ShortestSeekTime : DiskSchedule
    {
        public int[] numbers = new int[] { 24, 45, 3, 49, 100, 6, 2, 13, 16, 11, 12, 47, 48, 28, 50, 10, 62 };
        public int[] Schedule()
        {
            //List<int> sorted = new List<int>();
            //int a = numbers[0];
            //sorted = numbers.ToList();
            //sorted.Remove(a);
            //sorted.Sort();
            //List<int> check = new List<int>();
            //check.Add(a);      
            //for (int i = 1; i < numbers.Length - 1; i++)
            //{
            //    if (MakeItPositive(a - numbers[i+1]) < MakeItPositive(a - numbers[i-i]))
            //    {
            //        a = sorted.ElementAt(i+1);
            //    }
            //    else
            //    {
            //        a = sorted.ElementAt(i-1);

            //    }
            //    sorted.Remove(a);
            //    check.Add(a);
            //        }
            //return check.ToArray();

            List<int> sorted = new List<int>();
            sorted = numbers.ToList();
            sorted.Sort();
            int x = sorted.IndexOf(24);
    
            List<int> final = new List<int>();
            final.Add(24);
            for (int i = 0; i < sorted.Count(); i++)
            {
                if ( + sorted.ElementAt(x + 1) > x + sorted.ElementAt(x - 1))
                {
                    x = sorted.IndexOf(x + 1);
                }
                else
                { x = sorted.IndexOf(x - 1); }
                final.Add(sorted.ElementAt(x));
                sorted.RemoveAt(x);
            }
            return final.ToArray();
            }
        
        private int MakeItPositive(int x)
        {
            if (x < 0)
                return x = x * (-1);
            else
            return x;
        }
    }
}


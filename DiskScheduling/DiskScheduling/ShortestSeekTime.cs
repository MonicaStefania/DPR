using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    public class ShortestSeekTime : IDiskSchedule
    {
        public int[] numbers = new int[] { 24, 45, 3, 49, 100, 6, 2, 13, 16, 11, 12, 47, 48, 28, 50, 10, 62 };
        public int[] Schedule()
        {

            List<int> nb = numbers.ToList();
            List<int> temp = new List<int>();
            int a = numbers[0];
            temp.Add(a);
            nb.Sort();
            int x = a;
            int counter = 0;
            for (int i = 0; i < nb.Count(); i++)
            {
                if (nb.Count >= 0)
                {
                    if (nb.IndexOf(x) == 0)
                    {
                        x = nb.ElementAt(1);
                        temp.Add(x);
                        nb.Remove(x);
                        a = x;
                        counter++;
                    }
                    else if (nb.IndexOf(x) == nb.Count)
                    {
                        x = nb.ElementAt(nb.Count - 1);
                        temp.Add(x);
                        nb.Remove(x);
                        a = x;
                        counter++;
                    }
                    else
                    {
                        x = CompareNumbers(nb.ElementAt(nb.IndexOf(24) - 1), nb.ElementAt(nb.IndexOf(24) + 1), a);
                        if (counter < 5)
                        {
                            temp.Add(x);
                            nb.Remove(x);
                            a = x;
                            counter++;
                            nb.Sort();
                        }
                        else
                        
                        {
                            nb.Sort();
                            temp.Add(x);
                            nb.Remove(x);
                            a = x;
                            counter++;
                            nb.Add(x);

                        }
                    }
                }

            }
            return temp.ToArray();
        }


        private int MakeItPositive(int x)
        {
            if (x < 0)
                return x = x * (-1);
            else
                return x;
        }
       
        private int CompareNumbers(int a, int b, int x)
        {
            if (MakeItPositive(x - a) < MakeItPositive(x - b))
                return a;
            else return b;
          
        }
    }
}


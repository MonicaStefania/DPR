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
            List<int> nb = numbers.ToList();
            List<int> temp = new List<int>();
            temp.Add(FindTheClosest(nb, nb.ElementAt(0)));
            nb.Remove(nb.ElementAt(0));
            //remove number from list and add it later
            for (int i = 0; i < numbers.Length; i++)
            {
                int x = FindTheClosest(nb, temp.ElementAt(i));
                temp.Add(x);
                nb.Remove(x);
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
        private int FindTheClosest(List<int> mylist,int n)
        {
            mylist.Sort();
            if (mylist.Count != 0)
            {
                if (mylist.IndexOf(n) + 1 > mylist.Count())
                {
                    return mylist.ElementAt(mylist.Count());
                }
                else if (mylist.IndexOf(n) - 1 < 0)
                {
                    return mylist.ElementAt(0);
                }
                else
                {
                    int a = mylist.ElementAt(mylist.IndexOf(n) + 1);
                    int b = mylist.ElementAt(mylist.IndexOf(n) - 1);
                    if (MakeItPositive(a - n) < MakeItPositive(b - n))
                    {
                        return a;
                    }
                    else return b;
                }
            }
            else return -1;

        }
    }
}


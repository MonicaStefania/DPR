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

        //    temp.Add(FindTheClosest(nb, nb.ElementAt(0)));
        //    nb.Remove(nb.ElementAt(0));
        //    //remove number from list and add it later
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        int x = FindTheClosest(nb, temp.ElementAt(i));
        //        temp.Add(x);
        //        nb.Remove(x);
        //    }
        //    return temp.ToArray();
        //    }

        private int MakeItPositive(int x)
        {
            if (x < 0)
                return x = x * (-1);
            else
                return x;
        }
        //private int FindTheClosest(List<int> mylist,int n)
        //{
        //    mylist.Sort();
        //    if (mylist.Count != 0)
        //    {
        //        if (mylist.IndexOf(n) + 1 > mylist.Count())
        //        {
        //            return mylist.ElementAt(mylist.Count());
        //        }
        //        else if (mylist.IndexOf(n) - 1 < 0)
        //        {
        //            return mylist.ElementAt(0);
        //        }1
        //        else
        //        {
        //            int a = mylist.ElementAt(mylist.IndexOf(n) + 1);
        //            int b = mylist.ElementAt(mylist.IndexOf(n) - 1);
        //            if (MakeItPositive(a - n) < MakeItPositive(b - n))
        //            {
        //                return a;
        //            }
        //            else return b;
        //        }
        //    }
        //    else return -1;

        //}
        private int CompareNumbers(int a, int b, int x)
        {
            if (MakeItPositive(x - a) < MakeItPositive(x - b))
                return a;
            else return b;
          
        }
    }
}


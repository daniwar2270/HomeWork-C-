using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106zad2
{//str106/zad.2
    class Program
    {
        public static bool CheckForPairSumEqualToX(int[]s,int x)
        {
            int low = 0;
            int high = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
              
                if (s[low] + s[high] > x)
                {
                    high--;
                }
                else if (s[low] + s[high] < x)
                {
                    low++;
                }
                else if (low != high)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int X = 2;
            int[] S = new int[] { 1, 2, 3, 4, 5, 7, 20, 7 };
            Console.WriteLine(CheckForPairSumEqualToX(S,X));//shoudl return true
        }
    }
}

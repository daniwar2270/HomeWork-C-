using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestDistanceInPolygon
{
    class Program
    {//str.28/zad.5

        public static double[,] InputPointsOfPoly(int n)
        {
            double[,] points = new double[n,2];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("point[{0}]", i);
                for (int j = 0; j < 2; j++)
                {
                    if(j==0)Console.WriteLine("x{0}= ",i);//x
                    if (j == 1) Console.WriteLine("y{0}= ",i);//y

                    points[i-1, j] = double.Parse(Console.ReadLine());
                }
            }
            return points;
        }
        public static double GetMaxDist(double[,] points)
        {
            double maxDist = 0;
            int number = 0;
            while (number < points.GetLength(0)-1) {

                for (int i = 0; i < points.GetLength(0)-1; i++)
                {
                    double newDist = CalcDistanceBetwTwoPoints(points[number, 0], points[number, 1], points[i, 0], points[i, 1]);
                    if (!((number+i==1) || number -i == -1))// excluding neighbour points 
                    {
                       if (maxDist < newDist) maxDist = newDist;
                    }
                }
                number++;
            }
            return maxDist;
        }
        public static double CalcDistanceBetwTwoPoints(double x1, double y1, double x2, double y2)
        {
            double dist;
            double newX =x2-x1;
            double newY =y2 - y1;
            dist = Math.Sqrt((newX*newX)+(newY*newY));

            return dist;
        }
        static void Main(string[] args)
        {//size of polygon
            Console.WriteLine("Calculate maximum diameter for a 2D Polygon.");
            Console.WriteLine("In Pn n=?:\n n= ");
            int n = int.Parse(Console.ReadLine());
            //enter values for the points of the polygon
            double[,] points= InputPointsOfPoly(n);


            //calc the distances from every point-to-point and get max dist.
            Console.WriteLine(GetMaxDist(points));

        }
    }
}

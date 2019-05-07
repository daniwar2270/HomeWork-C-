using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBlueWhite
{//str.106/zad.4
    class Program
    {

        //make RED and BLUE pointers and a NORMAL pointer;
        //RED points at RED whenver RED is found swap with current RED pointer then find next RED
        //BLUE ---]]]]---
        //WHITE  
        
        public int Red ;//low
        public int Blue ;
        public int White ;//high
        //BLUe is mid

        public static string Examine(string [] matrix,int posIdx)//tells color of pos in matrix
        {
            return matrix[posIdx];
        }

        public static void Swap(ref string []matrix,int posA, int posB) // swap colors of the two positions
        {
            string temp = matrix[posA];
            matrix[posA] = matrix[posB];
            matrix[posB] = temp;
        }
       
        static void Main(string[] args)
        {
            Program p = new Program();
            
            string[]matrix= new string[] {"R","R","B","W","R","W","B","B","W"};//5 Reds  4 Blues 3 Whites should be [RRRRR][BBBB][WWW] after sort
            p.Red = 0;
            p.Blue = 0;
            p.White = matrix.Length - 1;

            /*for (int i = 0; i < p.pWhite; i++)
            {
                if (Examine(matrix, i) == "R") Swap(ref matrix, p.pRed++, i--);
                if (Examine(matrix, i)== "W") Swap(ref matrix, i--, p.pWhite--);
            }*/
            while (p.Blue<=p.White)
            {
                if (Examine(matrix, p.Blue) == "R") Swap(ref matrix, p.Red++, p.Blue++);
                else if (Examine(matrix, p.Blue) == "W") Swap(ref matrix, p.Blue, p.White--);
                else if (Examine(matrix, p.Blue) == "B") p.Blue++;
                        
            }

            foreach (var item in matrix)
            {
                Console.Write(item);
            }

        }
    }
}

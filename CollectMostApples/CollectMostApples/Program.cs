using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectMostApples
{//str.93/zad.6


    class Program
    {

        static void CollectMostApples(  string  currPath,ref string finalPath, int currScore, ref int finalScore, int row, int col, int[,] a, int posX, int posY)
        {
            if (posX == row - 1 && posY == col - 1)
            {

                if (currScore >= finalScore)
                {
                    finalScore = currScore;
                    currPath = currPath.Substring(0, currPath.Length - 1);
                    finalPath = currPath;

                }

                currScore = 0;
                currPath = "";
                return;
            }
            if (posX == row - 1)
            {
                currScore += a[posX, posY];
                CollectMostApples(  currPath += " R -",ref finalPath ,currScore, ref finalScore, row, col, a, posX, posY + 1);
                return;
            }
            if (posY == col - 1)
            {
                currScore += a[posX, posY];
                CollectMostApples( currPath + " D -", ref finalPath, currScore, ref finalScore, row, col, a, posX + 1, posY);
                return;
            }

            currScore += a[posX, posY];
            
            CollectMostApples( currPath + " R -", ref finalPath, currScore, ref finalScore, row, col, a, posX, posY + 1);
            CollectMostApples( currPath + " D -", ref finalPath, currScore, ref finalScore, row, col, a, posX + 1, posY);
            
        }
        static void Main(string[] args)
        {
            int startPosX = 0;// initially top left
            int startPosY = 0;//initially top left
            string path = "";//initially
            string pathFinal = "";//initially
            int score = 0;//initially
            int finalScore = 0;//initially
            int[,] matrix = new int[3, 4] { {0,1,4,1}, //can be changed !
                                            {1,2,1,2},
                                            {1,3,1,0}
                                                      };
            CollectMostApples( path,ref pathFinal, score, ref finalScore, matrix.GetLength(0), matrix.GetLength(1), matrix, startPosX, startPosY);

            Console.WriteLine("Maximum apples you can collect is "+finalScore+" apples!");
            Console.WriteLine("You can accomplish this by moving "+pathFinal+" starting from [0,0]");

            //use current matrix for test
            //need to traverse backtrack every possible path using only down/right movement
        }
    }
}

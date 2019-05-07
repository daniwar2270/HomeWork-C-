using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseMazeV3
{
    class Program
    {//str93/zad.4
        // w/ backtracking
        static int counter = 1;
        static int mouseX = 1; static int mouseY = 1;  // coords of mpuse
        static int cheeseX = 3; static int cheeseY = 2;// change coords of cheese

        public static int[,] maze = {
            { 0, 0, 0, 0 },//1: wall / 0:free space //
            { 0, 0, 1, 0 },
            { 0, 1, 1, 0 },
            { 0, 0, 0, 0 }
            
        };


        public static int[,] solution ={   //dont change used for solution
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 }

        };
        public static void FindAllPaths(int mouseX, int mouseY, int[,] sol)
        {
            

            if (!IsCellValid(mouseX, mouseY)) return;

            if (mouseX == cheeseX && mouseY == cheeseY)//FOUND le fromage
            {
                sol[mouseX, mouseY] = 9;//9 for cheese
                Console.WriteLine("Solution No." + (counter++));
                PrintSolution(sol);
               
                Console.WriteLine();
            }
            else if (IsCellValid(mouseX, mouseY))
            {
                maze[mouseX, mouseY] = 1;
                sol[mouseX, mouseY] = 1;

                FindAllPaths(mouseX + 1, mouseY, sol); //Down
                FindAllPaths(mouseX - 1, mouseY, sol); //Up
                FindAllPaths(mouseX, mouseY + 1, sol); //Right
                FindAllPaths(mouseX, mouseY - 1, sol); //Left

                maze[mouseX, mouseY] = 0;
            }
            sol[mouseX, mouseY] = 0;

            
        }

        public static bool IsCellValid(int x , int y)
        {
            if (x < 0 || x >= maze.GetLength(0))
            {
                return false;
            }

            if (y < 0 || y >= maze.GetLength(0))
            {
                return false;
            }
            if (maze[x, y] == 1)
            {
                return false;
            }


            return true;
        }

        public static void PrintSolution(int[,] a)
        {
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        } 
                
       
        static void Main(string[] args)
        {
            FindAllPaths(mouseX, mouseY, solution);
        }        
    }
}

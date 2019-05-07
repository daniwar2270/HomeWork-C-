using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilatorProblem//str61/zad1
{
    class Program
    {
       
        static bool isParenthCorrect(string parenths)
        {

            int openCount = 0;//opening parenths

            if (parenths.Length <= 1)
                return false;

            for (int i = 0; i < parenths.Length; i++)
            {
                if (parenths[i].Equals('('))
                    openCount++;

                else if (parenths[i].Equals(')'))
                {
                    openCount--;//pops opening parenths whenever a closing is found!
                    if (openCount < 0)
                        return false;
                }
            }

            return (openCount == 0);
        }
        static void Main(string[] args)
        {
            //testing 
            string test1 = "((())())()";//should return true;
            string test2 = ")()(";//should return false;
            string test3 = "())";//should return false
            Console.WriteLine(test1 + " returns " + isParenthCorrect(test1));
            Console.WriteLine(test2 + " returns " + isParenthCorrect(test2));
            Console.WriteLine(test3 + " returns " + isParenthCorrect(test3));

            
        }
    }
}

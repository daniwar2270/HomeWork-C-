using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {//str.28/zad.12
        public static bool CheckIfPolidrom(string word)
        {
            
            char[] charWord = word.ToCharArray();
            int reverseCount = word.Length - 1;
            bool isTrue = true;
            for (int i = 0; i < charWord.Length; i++)
            {
                if (charWord[i] != charWord[reverseCount]) isTrue = false;
                reverseCount--;
            }
            return isTrue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Check if word is polidrom");
            Console.WriteLine(CheckIfPolidrom(Console.ReadLine()));
        }
    }
}

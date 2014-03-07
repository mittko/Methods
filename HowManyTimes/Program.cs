using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//        Write a method that counts how many times given number appears in given array.
//        Write a test program to check if the method is working correctly

namespace HowManyTimes
{
    class Program
    {
        static ulong countAppears(int num,int[] arr)
        {
            ulong counter = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if(num == arr[i])
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int[] arr = {1,5,3,5,2,8,9,5,21,0,9,7,4,2,4,3,4,56,7,4,9,0,12,3,21,2,7,6,6,7,4};
            int[] toCheck =     { 1, 2, 5, 7, 4, 9, 45, -12 };
            ulong[] trueAnswers = { 1, 3, 3, 4, 5, 3, 0, 0 };
            for (int i = 0; i < toCheck.Length; i++)
            {
                ulong times = countAppears(toCheck[i], arr);
                if(times == trueAnswers[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("test {0} correct answer ", i+1);
                    Console.WriteLine("expected output :{0} ,your output :{0}",trueAnswers[i],times);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("test {0} wrong answer ", i + 1);
                    Console.WriteLine("expected output :{0} ,your output :{0}", trueAnswers[i],times);
                }
            }
           
        }
    }
}

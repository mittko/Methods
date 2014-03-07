using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   Write a method that checks if the element at given position in given array of integers is 
//   bigger than its two neighbors (when such exist).

namespace BiggerThanTwoNeighbours
{
    class Program
    {
        static int[] arr = { 1, 5, 3, 5, 2, 8, 9, 5, 21, 0, 9, 7, 4, 2, 4, 3, 4, 56, 7 };

        static String checkIsBigger(int index,int[] arr)
        {
            if(index < 0 || index >= arr.Length)
            {
                return "incorrect value";
            }
            if(index -1 >= 0 && index + 1 <= arr.Length - 1)
            {
                if(arr[index] > arr[index-1] && arr[index] > arr[index+1])
                {
                    return "element at position " +  index  + " is bigger than its two neighbours";
                }
                else  
                {
                    return "element at position " + index + " is not bigger than its two neighbours";
                }
            }
            return "element at position " + index + " has not two neighbours";
        }
        static void Main(string[] args)
        {
                     int elementAtPos = 2;
                     String check = checkIsBigger(elementAtPos,arr);
                     Console.WriteLine(check);
        }

    }
}

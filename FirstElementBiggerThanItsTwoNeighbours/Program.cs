using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//       Write a method that returns the index of the first element in array that is 
//       bigger than its neighbors, or -1, if there’s no such element

namespace FirstElementBiggerThanItsTwoNeighbours
{
    class Program
    {
        static String checkIsBigger(int index, int[] arr)
        {
            if (index < 0 || index >= arr.Length)
            {
                return "incorrect value";
            }
            if (index - 1 >= 0 && index + 1 <= arr.Length - 1)
            {
                if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                {
                    return "element at position " + index + " is bigger than its two neighbours";
                }
                else
                {
                    return "element at position " + index + " is not bigger than its two neighbours";
                }
            }
            return "element at position " + index + " has not two neighbours";
        }

        static int getIndex(int[] arr)
        {
            String response = String.Empty;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                response = checkIsBigger(i, arr);
                if (response == "element at position " + i + " is bigger than its two neighbours")
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5,6,7,8,9 };
            int index = getIndex(arr);
            Console.WriteLine(index);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a method that return the maximal element in a portion of array of integers 
//  starting at given index. Using it write another method that sorts an array in 
//  ascending / descending order.

namespace SortingInAscendindDescendingOrder
{
    class Program
    {
        public static int getBiggest(int[] arr,int index)
        {
            int biggest = arr[index];
            int bestIndex = index;
            
            for (int i = index+1; i < arr.Length; i++)
            {
               if(arr[i] >= biggest)
               {
                   biggest = arr[i];
                   bestIndex = i;
               }
            }
           
           
            return bestIndex;
        }

        static void sortArrays(int[] arr)
        {
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int big = getBiggest(arr, i);
                swap(i, big, arr, arr2);
            }

            printSortedArray(arr);
            printSortedArray(arr2);
        }

        static void swap(int pos,int big,int[] arr,int[] arr2)
        {

            for (int i = 0; i < 8;i++ )
            {
                int mask = (1 << i);
                int bitA = (arr[pos] & mask) >> i;
                int bitB = (arr[big] & mask) >> i;
                if(bitA == bitB)
                {
                    continue;
                }
                arr[pos] ^= mask;
                arr[big] ^= mask;
            }
                arr2[arr.Length - 1 - pos] = arr[pos];
        }

        static void printSortedArray(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr = {55,4,23,12,0,9,87,45,13,14,7};
            sortArrays(arr);
        }
    }
}

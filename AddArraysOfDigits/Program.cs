using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   Write a method that adds two positive integer numbers represented as arrays of digits 
//   (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of
//   the numbers that will be added could have up to 10 000 digits.

namespace AddArraysOfDigits
{
    class Program
    {
        static StringBuilder add(int[] arr1,int[] arr2)
        {
            StringBuilder result = new StringBuilder();
            int a = 0;
            int b = 0;
            int num = 0;
            int indexOfFirst = arr1.Length-1;
            int indexOfSecond = arr2.Length-1;
            int mind = 0;
            int max = Math.Max(arr1.Length, arr2.Length);
            for (int i = max; i >= 0;i--)
            {
                if (indexOfFirst >= 0)
                {
                    a = arr1[indexOfFirst];
                }
                else
                {
                    a = 0;
                }
                if (indexOfSecond >= 0)
                {
                    b = arr2[indexOfSecond];
                }
                else
                {
                    b = 0;
                }
                indexOfFirst--;
                indexOfSecond--;
                num = a + b + mind;
                if (num > 9)
                {
                    mind = num / 10;
                    num = num % 10;

                }
                else
                {
                    mind = 0;
                }
                result.Append(num);
               
            }
            result.Append(mind);
            while (result[result.Length-1] == '0')
            {
                result.Remove(result.Length - 1, 1);
            }
          
            return result;
          
        }

        static void Main(string[] args)
        {
            int[] arr1 = {1,0,2};
            int[] arr2 = {4,0,0};
            StringBuilder num = add(arr1, arr2);
            for (int i = num.Length - 1; i >= 0; i--)
            {
                     Console.Write(num[i]);
            }
            Console.WriteLine();
        }
    }
}

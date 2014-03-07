using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    Write a program to calculate n! for each n in the range [1..100]. 
//    Hint: Implement first a method that multiplies a number represented 
//    as array of digits by given integer number. 

namespace Factorial
{
    class Program
    {
        static int[] initToInt(String sb)

        {
            int[] arr = new int[sb.Length];
            for(int i = 0;i < arr.Length;i++)
            {
                arr[i] = int.Parse(sb[i].ToString());
            }
            return arr;
        }

        static int[] add(int[] arr1, int[] arr2)
        {
            StringBuilder result = new StringBuilder();
            int a = 0;
            int b = 0;
            int num = 0;
            int indexOfFirst = arr1.Length - 1;
            int indexOfSecond = arr2.Length - 1;
            int mind = 0;
            int max = Math.Max(arr1.Length, arr2.Length);
            for (int i = max; i >= 0; i--)
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
            while (result.Length > 0 && result[result.Length - 1] == '0')
            {
                result.Remove(result.Length - 1, 1);
            }
            result = reverse(result);
            int[] arr = new int[result.Length];
            for (int k = 0; k < arr.Length;k++ )
            {
               arr[k] = int.Parse(result[k].ToString());
              
            }
          
            return arr;

        }

       static int[] multiply(int[] a,int[] b)
        {
            int[] toAdd = { 0 };
            int mind = 0;
            int nul = 0;
            StringBuilder result = new StringBuilder();
           for(int i = a.Length-1;i >= 0;i--)
           {
               result = new StringBuilder();
               mind = 0;
               for(int j = b.Length-1;j >= 0;j--)
               {
                   int num = (a[i] * b[j]) + mind;
                  
                   mind = 0;
                   if(num > 9)
                   {
                       mind = num / 10;
                       num = num % 10;
                      
                   }
                   result.Append(num);
                 
               }
               result.Append(mind);
               result = reverse(result);
               result.Append('0', nul);
               nul++;
               toAdd = add(initToInt(result.ToString()),toAdd);
           
           }
           return toAdd;
        }

        static StringBuilder reverse(StringBuilder s)
       {
            while(s.Length > 0 && s[s.Length-1] == '0')
            {
                s.Remove(s.Length - 1, 1);
            }
           StringBuilder sb = new StringBuilder();
            for(int i = s.Length-1;i >= 0;i--)
            {
                sb.Append(s[i]);
            }
            return sb;
       }

        static void Main(string[] args)
        {
      
            Console.WriteLine(1);
            int[] toMulty = { 1 };
            for (int i = 1; i <= 100;i++ )
            {
               toMulty = multiply(initToInt(i.ToString()), toMulty);
               foreach (int factorial in toMulty)
               {
                   Console.Write(factorial);  // TESTED AND WORK -> http://en.wikipedia.org/wiki/Factorial
               }
               Console.WriteLine();
            }
            
        }
     }
  }


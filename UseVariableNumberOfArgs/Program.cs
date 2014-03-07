using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseVariableNumberOfArgs
{
    class Program
    {
        static int getMin(params int[] arr)
        {
            if(arr.Length == 0)
            {
                return 0;
            }
            int min = arr[0];
            for(int i = 1;i < arr.Length;i++)
            {
               if(arr[i] < min)
               {
                   min = arr[i];
               }
            }
            return min;
        }

        static int getMax(params int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static int getAverage(params int[] arr)
        {
            return getSum(arr) / arr.Length;
        }

        static int getSum(params int[] arr)
        {
            int sum = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static ulong getProduct(params int[] arr)
        {
            ulong product = 1;
            for(int i = 0;i < arr.Length;i++)
            {
                product *= (ulong)arr[i];
            }
            return product;
        }

        static void Main(string[] args)
        {
            Console.Write("min -> ");
            Console.WriteLine(getMin(1, 2));
            Console.Write("min -> ");
            Console.WriteLine(getMin(11, 2,3,4));
            Console.Write("max -> ");
            Console.WriteLine(getMax(21, 62,6));
            Console.Write("max -> ");
            Console.WriteLine(getMax(1, 36, 16, 4, 5));
            Console.Write("average ->");
            Console.WriteLine(getAverage(1,2,3,4,5,6,7,8,9));
            Console.Write("average ->");
            Console.WriteLine(getAverage(6, 7, 8, 9));
            Console.Write("sum ->");
            Console.WriteLine(getSum(4, 6, 3, 12, 8));
            Console.Write("sum ->");
            Console.WriteLine(getSum(4, 4));
            Console.Write("product ->");
            Console.WriteLine(getProduct(2, 3));
            Console.Write("product ->");
            Console.WriteLine(getProduct(25, 25));
        }
    }
}

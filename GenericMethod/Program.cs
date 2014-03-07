using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  * Modify your last program and try to make it work for any number type,
//   not just integer (e.g. decimal, float, byte, etc.). Use generic method 
//   (read in Internet about generic methods in C#).

namespace GenericMethod
{
    class Program
    {


        static T getMin<T>(params T[] arr) where T : IComparable<T>
        {
            T min = arr[0];
            for(int i = 1;i < arr.Length;i++)
            {
                if(min.CompareTo(arr[i]) > 0)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static T getMax<T>(params T[] arr) where T : System.IComparable<T>
       {
           T max = arr[0];
           for(int i = 1;i < arr.Length;i++)
           {
               if(max.CompareTo(arr[i]) < 0)
               {
                   max = arr[i];
               }
           }
           return max;
        }

        static T getSum<T>(params T[] arr) 
        {
            dynamic sum = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                sum += arr[i] ;
            }
            return sum;
        }


        static T getAverage<T>(params T[] arr)
        {
            return (dynamic)getSum(arr) / arr.Length;
        }

        static T getProduct<T>(params T[] arr) 
        {
            dynamic product = 1;
            for(int i = 0;i < arr.Length;i++)
            {
                product *= arr[i];
            }
            return product;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(getMin('w','r'));
            Console.WriteLine(getMax("a","t"));
            Console.WriteLine(getSum(2.5,3,5,9.2));
            Console.WriteLine(getAverage(25,25));
            Console.WriteLine(getProduct(2, 4.5));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//  Write a method that adds two polynomials. Represent them as arrays of their 
//  coefficients as in the example below:
//  x2 + 5 = 1x2 + 0x + 5 -> 5 0 1

namespace AddTwoPolinomials
{
    class Program
    {
        static int[] sumOfPolinoms(int[] first, int[] second, int max)
        {
            int min = 0;
            String smaller = String.Empty;
            int[] sum = new int[max];

            if(first.Length < second.Length)
            {
                min = first.Length;
                smaller = "first";
            }
            else
            {
                min = second.Length;
                smaller = "second";
            }

            for(int i = 0;i < min;i++)
            {
                sum[i] = first[i] + second[i];
            }

            for(int j = min;j < max;j++)
            {
                if(smaller == "first")
                {
                    sum[j] = second[j];
                }
                else
                {
                    sum[j] = first[j];
                }
            }
            return sum;
        }

        static int[] substractOfPolinoms(int[] first, int[] second, int max)
        {
            int min = 0;
            String smaller = String.Empty;
            int[] sum = new int[max];

            if (first.Length < second.Length)
            {
                min = first.Length;
                smaller = "first";
            }
            else
            {
                min = second.Length;
                smaller = "second";
            }

            for (int i = 0; i < min; i++)
            {
                sum[i] = first[i] - second[i];
            }

            for (int j = min; j < max; j++)
            {
                if (smaller == "first")
                {
                    sum[j] = -second[j];
                }
                else
                {
                    sum[j] = first[j];
                }
            }
            return sum;
        }

        static int[] MultiplyPolinom(int[] firstPolinom, int[] secondPolinom, int[] result)
        {
           
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < firstPolinom.Length; i++)
            {
                for (int j = 0; j < secondPolinom.Length; j++)
                {
                    int position = i + j;
                    result[position] += (firstPolinom[i] * secondPolinom[j]);
                }
            }
            return result;
        }

        static void PrintPolinom(int[] polinom)
        {
            for (int i = polinom.Length - 1; i >= 0; i--)
            {
                if (polinom[i] != 0 && i != 0)
                {
                    if (polinom[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} +", i, polinom[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polinom[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polinom[i]);
                }
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] firstPolinom = { 5,-1};
            int[] secondPolinom = { 10,-5,6};
            int max = Math.Max(firstPolinom.Length, secondPolinom.Length);
            int[] sum = sumOfPolinoms(firstPolinom, secondPolinom, max);
            PrintPolinom(sum);
            int[] subtract = substractOfPolinoms(firstPolinom, secondPolinom, max);
            PrintPolinom(subtract);
            int[] result = new int[firstPolinom.Length + secondPolinom.Length];
            int[] multiply = MultiplyPolinom(firstPolinom, secondPolinom, result);
            PrintPolinom(multiply);
        }
    }
}

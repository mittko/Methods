using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a method GetMax() with two parameters that returns the bigger of two integers.
//  Write a program that reads 3 integers from the console and prints the biggest of them
//  using the method GetMax().

namespace GetMax
{
    class Program
    {
        static int getMax(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            int max = 0;
            for(int i = 0;i < 3;i++)
            {
                Console.Write("num[{0}] = ",i+1);
                int num = int.Parse(Console.ReadLine());
                max = getMax(max, num);
            }
            Console.WriteLine("max element -> {0}", max);
        }
    }
}

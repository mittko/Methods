using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    Write a method that returns the last digit of given integer as an English word. 
//    Examples: 512  "two", 1024  "four", 12309  "nine".

namespace ReturnLastDigit
{
    class Program
    {
        static int getLastDigit(ulong num)
        {
            int ret = 0;
            String toStr = num.ToString();
            char last = toStr[toStr.Length - 1];
            switch(last)
            {
                case '0' : ret = 0; break;
                case '1': ret = 1; break;
                case '2': ret = 2; break;
                case '3': ret = 3; break;
                case '4': ret = 4; break;
                case '5': ret = 5; break;
                case '6': ret = 6; break;
                case '7': ret = 7; break;
                case '8': ret = 8; break;
                case '9': ret = 9; break;
                default: break;
            }
            return ret;
        }

        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            int last = getLastDigit(num);
            Console.WriteLine("last digit of {0} is {1}", num, last);
        }
    }
}

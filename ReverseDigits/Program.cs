using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//       Write a method that reverses the digits of given decimal number. Example: 256  652

namespace ReverseDigits
{
    class Program
    {
        static String reverseDigits(ulong num)
        {
            StringBuilder sb = new StringBuilder();
            ulong remainder = 0;
            while (num > 0)
            {
                remainder = num % 10;
                if(remainder != 0)
                {
                    sb.Append(remainder);
                }
                else
                {
                    sb.Append(remainder);
                }
                num /= 10;
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("enter num : ");
            ulong num = ulong.Parse(Console.ReadLine());
            String reversed = reverseDigits(num);
            Console.WriteLine("redersed : {0}",reversed);
        }
    }
}

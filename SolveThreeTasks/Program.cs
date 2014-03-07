using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveThreeTasks
{
    class Program
    {
        static string reverseDigits(int num)
        {
            StringBuilder sb = new StringBuilder();
            while(num > 0)
            {
                sb.Append(num % 10);
                num /= 10;
            }
            return sb.ToString();
        }

        static double solveLinearEquation(int a,int b)
        {
            return -b / a;
        }
        static double calcAverage(string seq)
        {
            int[] arr = new int[seq.Length];
            for(int i = 0;i < arr.Length;i++)
            {
                arr[i] = int.Parse(seq[i].ToString());
            }
            double sum = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
        
        static void startProgram()
        {
            Console.WriteLine("choise a) ,b) or c) to solve given problem: ");
            Console.WriteLine("a) Reverses the digits of a number");
            Console.WriteLine("b) Calculates the average of a sequence of integers");
            Console.WriteLine("c) Solves a linear equation a * x + b = 0");
            String choice = Console.ReadLine();
            if(choice == "a")
            {
                Console.Write("enter number:");
                int num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    Console.WriteLine("incorrect value , num should be >= 0");
                    return;
                }
                Console.WriteLine(reverseDigits(num));
            }
            else if(choice == "b")
            {
                Console.WriteLine("enter sequence of integers");
                String sequence = Console.ReadLine();
                if(sequence == String.Empty)
                {
                    Console.WriteLine("sequence should not be empty");
                    return;
                }
                Console.WriteLine(calcAverage(sequence));
            }
            else if(choice == "c")
            {
                Console.WriteLine("solves a linear equation a * x + b = 0");
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                if(a == 0)
                {
                    Console.WriteLine("a should not be 0");
                    return;
                }
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(solveLinearEquation(a,b));
            }
            else
            {
                Console.WriteLine("incorrect input : choice a ,b or c");
                Console.WriteLine("Program will exit");
            }
        }
        static void Main(string[] args)
        {
            startProgram();
        }
    }
}

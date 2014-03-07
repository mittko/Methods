using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Write a method that asks the user for his name and prints “Hello, <name>” 
//   (for example, “Hello, Peter!”). Write a program to test this method.

namespace PrintName
{
    class Program
    {
        static void printName()
        {
            Console.Write("enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",name);
        }
        static void Main(string[] args)
        {
            printName();
        }
    }
}

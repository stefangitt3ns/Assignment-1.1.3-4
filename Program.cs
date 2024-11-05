using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._1._3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Assignement 3 & 4";


            // Assignment 3 
            Console.WriteLine("This is a calculator to add two numbers together. ");
            Console.WriteLine("Enter your numbers, press enter after each number");

            double firstNum = Convert.ToDouble(Console.ReadLine());
            double secondNum = Convert.ToDouble(Console.ReadLine());

            double answer = firstNum + secondNum;

            Console.WriteLine($"The answer to your problem is {answer}, have a nice day!");


            // Assignment 4 

            Console.WriteLine("This is a calculator to divide two numbers together. ");
            Console.WriteLine("Enter your numbers, press enter after each number");

            double firstDiv = Convert.ToDouble(Console.ReadLine());
            double secondDiv = Convert.ToDouble(Console.ReadLine());

            double answerDiv = firstDiv / secondDiv;

            Console.WriteLine($"The answer to your problem is {answerDiv}, have a nice day!");

            Console.Read();
           
        }
    }
}

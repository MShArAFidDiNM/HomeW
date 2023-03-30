﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            bool check = int.TryParse(str, out int number);
            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial value of the number {number} is equal to {factorial} ");
        }
    }
}

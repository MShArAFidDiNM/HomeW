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
            int Number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= Number; i++) if (Number % i == 0) count++;
            if (count == 2) Console.WriteLine("Prime number ");
            else Console.WriteLine("is not prime number  ");
            Main(args);

        }
    }
}

﻿using System;

namespace ex._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o numero que deseja multiplicar: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.WriteLine("===========|            |==============");
            Console.WriteLine("================|  |===================");
            Console.WriteLine("================|  |===================");
            Console.WriteLine("================|  |===================");
            Console.WriteLine("================|  |===================");
            Console.WriteLine("================|__|===================");
            Console.WriteLine("=======================================");
            Console.WriteLine("============== Tabuada ================");
            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine(" 1 x " + n + " = " + (1 * n));
            Console.WriteLine(" 2 x " + n + " = " + (2 * n));
            Console.WriteLine(" 3 x " + n + " = " + (3 * n));
            Console.WriteLine(" 4 x " + n + " = " + (4 * n));
            Console.WriteLine(" 5 x " + n + " = " + (5 * n));
            Console.WriteLine(" 6 x " + n + " = " + (6 * n));
            Console.WriteLine(" 7 x " + n + " = " + (7 * n));
            Console.WriteLine(" 8 x " + n + " = " + (8 * n));
            Console.WriteLine(" 9 x " + n + " = " + (9 * n));
            Console.WriteLine(" 10 x " + n + " = " + (10 * n));
        }
    }
}

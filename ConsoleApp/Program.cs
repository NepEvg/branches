﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("выберите операцию [ + | - | * | / ] ");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "+":
                    Console.WriteLine(a+b);
                    break;
                case "-":

                    break;
                case "*":

                    break;
                case "/":

                    break;
                default:
                    Console.WriteLine("такой операции нет");
                    break;
            }
        }
    }
}

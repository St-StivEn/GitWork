﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GitWork
{
    internal class Program
    {
        public static int StepNum(int number,int stepen)
        {
            int sum = Convert.ToInt32(Math.Pow(number, stepen));    //выводим  число указанного стпени в переменную

            Console.WriteLine($"{number}^{stepen}= {sum}.");     //вывод в консоль

            return sum;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать");
                Console.WriteLine("1. Возвести число в степень.");
                Console.WriteLine("2. Возвести число в куб.");
                try
                {
                    Console.Write("Выбирите действие : ");
                    int a = int.Parse(Console.ReadLine());
                    if(a == 1)
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите число и его степень:");
                            try
                            {
                                Console.Write("1. Число : ");
                                int number = int.Parse(Console.ReadLine());
                                Console.WriteLine("2. Степень :");
                                int stepen = int.Parse(Console.ReadLine());
                                StepNum(number, stepen);
                            }
                            catch
                            {

                            }
                        }
                    }
                    if(a == 2)
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите число :");
                            try
                            {
                                int number = int.Parse(Console.ReadLine());
                                

                            }
                            catch
                            {

                            }
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Повторите ввод!");
                }
            }
        }
    }
}

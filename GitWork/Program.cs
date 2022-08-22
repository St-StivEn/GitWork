using System;
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
            int sum = 1;
            for (int i = 0; i < stepen; i++)
                sum *= number;             //выводим  число указанного стпени в переменную

            Console.WriteLine($"{number}^{stepen} = {sum}.");     //вывод в консоль

            return sum;
        }
        public static int KubNum(int number)
        {
            int sum = 1;
            for (int i =0; i< 3;i++)
                sum *= number;

            Console.WriteLine($"{number}^3 = {sum}");

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
                                Console.Write("2. Степень :");
                                int stepen = int.Parse(Console.ReadLine());
                                StepNum(number, stepen);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Повторите ввод!");
                            }
                        }
                    }
                    if(a == 2)
                    {
                        while (true)
                        {
                            Console.Write("Введите число :");
                            try
                            {
                                int number = int.Parse(Console.ReadLine());
                                
                                KubNum(number);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Повторите ввод!");
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

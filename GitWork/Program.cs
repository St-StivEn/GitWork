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
        public int StepNum(int number,int stepen)
        {
            int sum = Convert.ToInt32(Math.Pow(number, stepen));    //выводим  число указанного стпени в переменную

            Console.WriteLine($"{number}^{stepen}= {sum}.");     //вывод в консоль

            return sum;
        }
        static void Main(string[] args)
        {
         
        }
    }
}

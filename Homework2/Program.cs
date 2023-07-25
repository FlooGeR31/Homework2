using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
    (Если решаете математически через рандом, то проверка не нужна на трехзначность. Если через строки, то она обязательна)
456-> 5
782-> 8
918-> 1
*/

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(100, 1000);
            string NumStr = num.ToString();
            if (NumStr.Length == 3)
            {
                Console.WriteLine("Данный день является выходным");
            }
            

            Console.ReadKey();
            

            Console.ReadKey();
            

            Console.ReadKey();
            

            Console.ReadKey();
            

            Console.ReadKey();
            

            Console.ReadKey();
            

            Console.ReadKey();
            

            Console.ReadKey();
        }
    }
}

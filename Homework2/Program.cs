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
            FirstTask(args);
            SecondTask(args);
            ThirdTask(args);
        }
        public static void FirstTask(string[] args)
        {
            /*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на
             * выходе показывает вторую цифру этого числа. 
                (Если решаете математически через рандом, то проверка не нужна 
            на трехзначность. Если через строки, то она обязательна)
            456-> 5
            782-> 8
            918-> 1
            */
            int num = new Random().Next(100, 1000);
            string NumStr = num.ToString();
            if (NumStr.Length == 3)
            {
                Console.WriteLine($"Выпало число: {num}");
                Console.WriteLine($" Число по середине: {NumStr[1]}");
            }
            Console.ReadKey();
        }
        public static void SecondTask(string[] args)
        {
            
            /* Задача 13: Напишите программу, которая выводит третью цифру 
              * заданного числа или сообщает, что третьей цифры нет. 
              * (Если решаете математически максимум берем 100000)
              645-> 5
              78->третьей цифры нет
              32679-> 6*/
            int num = new Random().Next(10000);
            string NumStr = num.ToString();

            if (NumStr.Length == 3 || NumStr.Length == 4)
            {
                Console.WriteLine($"Третья цифра числа {num} : {NumStr[2]}");
            }
            else
            {
                Console.WriteLine($"Третьей цифры в числе {num} : нет");
            }
            Console.ReadKey();

        }

        public static void ThirdTask(string[] args)
         {
            /*Задача 15: Напишите программу, которая принимает на вход цифру,
             *обозначающую день недели, и проверяет, является ли этот день выходным.
             * (Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
                6->да
                7->да
                1->нет */

            Console.WriteLine("Введите цифру от 1 до 7, где \n 1-Понедельник\n 2-Вторник\n 3-Среда\n 4-Четверг\n 5-Пятница\n 6-Суббота\n 7-Воскресенье ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 6 || number == 7)
            {
                Console.WriteLine("Данный день является выходным");
            }
            else if (number < 1 || number > 7)
            {
                Console.WriteLine("Такого дня недели нет в Нашем списке :)");
            }
            else
            {
                Console.WriteLine("Данный день не является выходным");
            }

            Console.ReadKey();
        }

    }
}

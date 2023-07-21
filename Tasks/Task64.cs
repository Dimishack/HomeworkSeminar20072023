using System;

namespace HomeworkSeminar20072023.Tasks
{
    /*
     * Задача 64: Задайте значение N. Напишите программу, 
     * которая выведет все натуральные числа в промежутке от N до 1. 
     * Выполнить с помощью рекурсии.
     * N = 5 -> "5, 4, 3, 2, 1"
     * N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
     */
    internal class Task64
    {
        internal static void NumbersInDescending()
        {
            uint maxNumber;

            Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, " +
                "которая выведет все натуральные числа в промежутке от N до 1." +
                " Выполнить с помощью рекурсии.\n" + new string('-', 30));
            while (true)
            {
                Console.Write("Введите целое положительное число N для вывода чисел в промежутке от N до 1" +
                    "\nN = ");
                if (UInt32.TryParse(Console.ReadLine(), out var number))
                {
                    maxNumber = number;
                    break;
                }
                Console.WriteLine("Ошибка: введенное значение не является целым положительным числом! Попробуйте еще раз");
            }
            Console.WriteLine("Вывод чисел от {0} до 1", maxNumber);
            WriteNumbers(maxNumber);
        }

        private static void WriteNumbers(uint maxNumber)
        {
            if (maxNumber > 0)
            {
                Console.Write(maxNumber);
                if (maxNumber > 1) Console.Write(", ");
                WriteNumbers(maxNumber - 1);
            }
        }
    }
}

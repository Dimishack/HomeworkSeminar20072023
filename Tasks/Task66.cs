using System;

namespace HomeworkSeminar20072023.Tasks
{
    /*
     * Задача 66: Задайте значения M и N. Напишите программу, 
     * которая найдёт сумму натуральных элементов в промежутке от M до N.
     * M = 1; N = 15 -> 120
     * M = 4; N = 8. -> 30
     */
    internal class Task66
    {
        internal static void SumBethNumbers()
        {
            uint GetNumber(string symbol)
            {
                while (true)
                {
                    Console.Write(symbol + " = ");
                    if (UInt32.TryParse(Console.ReadLine(), out var number))
                        return number;
                    Console.WriteLine("Ошибка: данное значение не является натуральным числом! Попробуйте еще раз");
                }
            }

            uint minNumber, maxNumber;

            Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, " +
                "которая найдёт сумму натуральных элементов в промежутке от M до N." +
                "\n" + new string('-', 30));
            Console.WriteLine("Введите натуральные числа M и N для нахождения суммы в их промежутке" +
                "\nПримечание: M должен быть меньше N");
            while (true)
            {
                minNumber = GetNumber("M");
                maxNumber = GetNumber("N");
                if (minNumber < maxNumber)
                    break;
                Console.WriteLine("Ошибка: минимальное число больше или равен максимальному! Попробуйте еще раз");
            }
            Console.WriteLine("Сумма значений в промежутке от {0} до {1} = {2}", minNumber, maxNumber, SumNumbers(minNumber, maxNumber));
        }

        private static uint SumNumbers(uint min, uint max)
        {
            uint sum = min;
            if (min < max) sum += SumNumbers(++min, max); ;
            return sum;
        }
    }
}

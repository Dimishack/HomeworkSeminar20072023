using System;

namespace HomeworkSeminar20072023.Tasks
{
    /*
     * Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
     * Даны два неотрицательных числа m и n.
     * m = 2, n = 3 -> A(m,n) = 9
     * m = 3, n = 2 -> A(m,n) = 29
     */
    internal class Task68
    {
        internal static void FunctionAckerman()
        {
            uint GetNumber(char symbol)
            {
                while (true)
                {
                    Console.Write(symbol + " = ");
                    if (UInt32.TryParse(Console.ReadLine(), out var number))
                        return number;
                    Console.WriteLine("Ошибка: данное значение не является натуральным числом! Попробуйте еще раз");
                }
            }
            Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
            Console.WriteLine("Введите натуральные числа m и n для вычисления по функции Аккермана");
            uint m = GetNumber('m');
            uint n = GetNumber('n');
            Console.WriteLine("A({0},{1}) = {2}", m, n, A(m, n));
        }

        private static uint A(uint m, uint n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return A(m - 1, 1);
            else if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
            return default;
        }
    }
}

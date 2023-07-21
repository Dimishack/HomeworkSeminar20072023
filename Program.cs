using HomeworkSeminar20072023.Tasks;
using System;

namespace HomeworkSeminar20072023
{
    internal class Program
    {
        static void Main()
        {
			try
			{
                ConsoleKey key;
                Console.WriteLine("Добро пожаловать в программу с выполненными задачами №64, 66 и 68");
                do
                {
                    Console.WriteLine("Выберите номер из списка с задачами, к которому Вы хотите перейти " +
                        "\n(для выхода из программы нажмите <Enter>)");
                    Console.WriteLine("1) Задача №64 \n2) Задача №66 \n3) Задача №68");
                    key = Console.ReadKey(false).Key;
                    Console.WriteLine();
                    switch (key)
                    {
                        case ConsoleKey.Enter:
                            break;
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.D1:
                            Task64.NumbersInDescending();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.D2:
                            Task66.SumBethNumbers();
                            WaitUser();
                            break;
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.D3:
                            Task68.FunctionAckerman();
                            WaitUser();
                            break;
                        default:
                            Console.WriteLine("Ошибка: Данного номера с задачей нет! Выберите другой.");
                            break;
                    }
                } while (key != ConsoleKey.Enter);
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw;
			}
			finally
			{
                Console.WriteLine("\nНажмите любую клавишу для выхода из программы...");
				Console.ReadKey(true);
            }
        }

		private static void WaitUser()
		{
            Console.WriteLine("\nНажмите любую клавишу для перехода к следующей задаче...");
			Console.ReadKey(true);
			Console.Clear();
        }
    }
}
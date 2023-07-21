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
                Console.WriteLine("Задача №64");
				Task64.NumbersInDescending();
				WaitUser();
                Console.WriteLine("Задача №66");
				Task66.SumBethNumbers();
				WaitUser();
                Console.WriteLine("Задача №68");
				Task68.Ackerman();
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
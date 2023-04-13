using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п2_задание5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное целое число диапазона:");
            int maxNumber = Convert.ToInt32(Console.ReadLine());      
            Random random = new Random();
            int targetNumber = random.Next(0, maxNumber + 1);

            Console.WriteLine($"Загадано случайное число от 0 до {maxNumber}. Попробуйте угадать!");

            while (true)
            {
                Console.WriteLine("Введите ваше предположение (или нажмите Enter для выхода):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"Было загадано число: {targetNumber}. До свидания!");
                    break;
                }

                int guess;
                if (int.TryParse(input, out guess))
                {
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    else
                    {
                        Console.WriteLine("Поздравляю! Вы угадали число.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Введите целое число.");
                }
            }
        }
    }
}
    
